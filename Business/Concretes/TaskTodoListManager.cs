using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Task;

namespace Business.Concretes
{
    public class TaskTodoListManager : ITaskTodoListService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskTodoListRepository _taskTodoListRepository;
        private readonly ITaskTodoService _taskTodoService;

        public TaskTodoListManager(ITaskTodoListRepository taskTodoListRepository, ITaskTodoService taskTodoService, ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
            _taskTodoListRepository = taskTodoListRepository;
            _taskTodoService = taskTodoService;
        }

        public IResult Add(TaskTodoList taskTodoList)
        {
            var result = _taskRepository.Get(p => p.Id.Equals(taskTodoList.TaskId));
            if (result == null) return new ErrorResult("Task bulunamadı");
            _taskTodoListRepository.Add(taskTodoList);
            return new SuccessResult("Ekleme işlemi başarılı");
        }

        public IResult Delete(int id)
        {
            var result = _taskTodoListRepository.Get(p => p.Id.Equals(id));
            if (result == null) return new ErrorResult("Silme işlemi gerçekleştirilemedi");

            var deletedTaskTodos = _taskTodoService.GetAllByTodoListId(id).Data;
            if (!(deletedTaskTodos == null || !deletedTaskTodos.Any()))
                _taskTodoService.DeleteAll(deletedTaskTodos);

            _taskTodoListRepository.Delete(result);
            return new SuccessResult("Silme işlemi başarılı");

        }

        public IResult DeleteAll(List<TaskTodoList> taskTodoLists)
        {
            if ((taskTodoLists == null || !taskTodoLists.Any())) return new ErrorResult("Silme işlemi gerçekleştirilemedi");

            foreach (var taskTodoList in taskTodoLists)
            {
                Delete(taskTodoList.Id);
            }
            return new SuccessResult();
        }

        public IDataResult<List<TaskTodoList>> GetAllByTaskId(int taskId)
        {
            var result = _taskTodoListRepository.GetAll(p => p.TaskId.Equals(taskId));
            return new SuccessDataResult<List<TaskTodoList>>(result);
        }

        public IDataResult<List<TaskTodoListDto>> GetAllWithTodoByTaskId(int taskId)
        {
            var result = _taskTodoListRepository.GetAllWithTodoByTaskId(taskId);
            return new SuccessDataResult<List<TaskTodoListDto>>(result);
        }

        public IResult Update(TaskTodoList taskTodoList)
        {
            var updatedTaskTodoList = _taskTodoListRepository.Get(p => p.Id.Equals(taskTodoList.Id));
            if (updatedTaskTodoList == null) return new ErrorResult("Güncellenecek Task todo list bulunamadı");

            updatedTaskTodoList.Title = taskTodoList.Title;
            _taskTodoListRepository.Update(updatedTaskTodoList);
            return new SuccessResult("Güncellendi");
        }
    }
}
