using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entities.Dtos.Task;

namespace Business.Concretes
{
    public class TaskManager : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskMemberService _taskMemberService;
        private readonly ITaskLabelService _taskLabelService;
        private readonly ITaskAttachmentService _taskAttachmentService;
        private readonly ITaskCommentService _taskCommentService;
        private readonly ITaskTodoListService _taskTodoListService;

        public TaskManager(ITaskRepository taskRepository, ITaskMemberService taskMemberService, ITaskLabelService taskLabelService,
            ITaskAttachmentService taskAttachmentService, ITaskCommentService taskCommentService, ITaskTodoListService taskTodoListService)
        {
            _taskRepository = taskRepository;
            _taskMemberService = taskMemberService;
            _taskLabelService = taskLabelService;
            _taskAttachmentService = taskAttachmentService;
            _taskCommentService = taskCommentService;
            _taskTodoListService = taskTodoListService;
        }
        public IResult Add(AddTaskDto taskDto)
        {
            var task = taskDto.Task;
            var maxOrder = _taskRepository.GetAll(p => p.TaskListId.Equals(task.TaskListId)).OrderByDescending(p => p.OrderNo).FirstOrDefault();
            task.CreatedDate = DateTime.Now;
            task.OrderNo = (maxOrder != null) ? maxOrder.OrderNo + 1000 : 1000;


            _taskRepository.Add(task);

            if (taskDto.AddUserIds != null) { _taskMemberService.Add(taskDto.AddUserIds, task.Id); }

            if (taskDto.AddLabelIds != null) { _taskLabelService.Add(taskDto.AddLabelIds, task.Id); }

            return new SuccessResult("Görev eklendi.");
        }

        public IResult Delete(int taskId)
        {
            var task = _taskRepository.Get(p => p.Id.Equals(taskId));
            if (task == null) return new ErrorResult("Silinecek görev bulunamadı");

            var taskMembers = _taskMemberService.GetAllIdByTaskId(taskId).Data;
            if (taskMembers != null) { _taskMemberService.DeleteAllByTaskMemberIds(taskMembers); }

            var taskLabels = _taskLabelService.GetAllIdByTaskId(taskId).Data;
            if (taskLabels != null) { _taskLabelService.DeleteAllByTaskLabelIds(taskLabels); }


            var taskAttachments = _taskAttachmentService.GetAllIdByTaskId(taskId).Data;
            if (taskAttachments != null) { _taskAttachmentService.DeleteAll(taskAttachments); }

            var taskComments = _taskCommentService.GetAllByTaskId(taskId).Data;
            if (taskComments != null) { _taskCommentService.DeleteAll(taskComments); }

            var taskTodoLists = _taskTodoListService.GetAllByTaskId(taskId).Data;
            if (taskTodoLists != null) { _taskTodoListService.DeleteAll(taskTodoLists); }


            _taskRepository.Delete(task);
            return new SuccessResult("Görev silindi.");
        }

        public IResult DeleteAll(List<Entities.Concretes.Task> tasks)
        {
            if (tasks == null || !tasks.Any()) return new ErrorResult("Silinecek görevler bulunamadı");
            foreach (var task in tasks)
            {
                Delete(task.Id);
            }
            return new SuccessResult();
        }

        public IDataResult<List<Entities.Concretes.Task>> GetAllByTaskListId(int taskListId)
        {
            var result = _taskRepository.GetAll(p => p.TaskListId.Equals(taskListId));
            return new SuccessDataResult<List<Entities.Concretes.Task>>(result);
        }

        public IDataResult<TaskViewDto> GetById(int taskId)
        {
            var result = _taskRepository.GetTaskByTaskId(taskId);
            return (result != null) ? new SuccessDataResult<TaskViewDto>(result) : new ErrorDataResult<TaskViewDto>("Görev bulunamadı.");
        }

        public IResult Update(EditTaskDto taskDto)
        {
            var task = _taskRepository.Get(p => p.Id.Equals(taskDto.Task.Id));
            if (task == null) return new ErrorResult("Güncellenecek görev bulunamadı");

            task.Name = taskDto.Task.Name;
            task.Description = taskDto.Task.Description;
            task.DueDate = taskDto.Task.DueDate;


            if (taskDto.AddUserIds != null) { _taskMemberService.Add(taskDto.AddUserIds, task.Id); }
            if (taskDto.RemoveUserIds != null) { _taskMemberService.DeleteAllByUserIdsAndTaskId(taskDto.RemoveUserIds, task.Id); }

            if (taskDto.AddLabelIds != null) { _taskLabelService.Add(taskDto.AddLabelIds, task.Id); }
            if (taskDto.RemoveLabelIds != null) { _taskLabelService.DeleteAllByLabelIdsAndTaskId(taskDto.RemoveLabelIds, task.Id); }

            _taskRepository.Update(task);

            return new SuccessResult("Görev güncellendi.");
        }

        public IResult UpdateOrder(TaskOrderEditDto taskOrderEditDto)
        {
            var task = _taskRepository.Get(p => p.Id.Equals(taskOrderEditDto.Id));
            if (taskOrderEditDto.TaskListId != 0)
            {
                task.TaskListId = taskOrderEditDto.TaskListId;
            }
            task.OrderNo = taskOrderEditDto.OrderNo;
            _taskRepository.Update(task);
            return new SuccessResult("Görevin konumu başarılı şekilde değiştirildi");
        }
    }
}
