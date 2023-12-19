using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos.TaskList;

namespace Business.Concretes
{
    public class TaskListManager : ITaskListService
    {
        private readonly ITaskListRepository _taskListRepository;
        private readonly ITaskService _taskService;

        public TaskListManager(ITaskListRepository taskListRepository, ITaskService taskService)
        {
            _taskListRepository = taskListRepository;
            _taskService = taskService;
        }

        public IResult Add(TaskList taskList)
        {
            var result = _taskListRepository.GetAll(p => p.BoardId.Equals(taskList.BoardId)).OrderByDescending(p => p.OrderNo).FirstOrDefault();

            taskList.OrderNo = (result != null) ? result.OrderNo + 1000 : 1000;
            _taskListRepository.Add(taskList);
            return new SuccessResult("Ekleme işlemi başarılı.");

        }

        public IResult Delete(int taskListId)
        {
            var removedTaskList = _taskListRepository.Get(p => p.Id.Equals(taskListId));
            if (removedTaskList == null) return new ErrorResult("Silinecek görev listesi bulunamadı.");

            var removedTasks = _taskService.GetAllByTaskListId(taskListId).Data;

            if (removedTasks != null)
            {
                _taskService.DeleteAll(removedTasks);
            }

            _taskListRepository.Delete(removedTaskList);
            return new SuccessResult("Silme işlemi başarılı.");
        }

        public IResult DeleteAll(List<TaskList> taskLists)
        {
            if (taskLists == null || !taskLists.Any()) return new ErrorResult("Silinecek görev listeleri bulunamadı.");
            foreach (var taskList in taskLists)
            {
                Delete(taskList.Id);
            }
            return new SuccessResult();
        }

        public IDataResult<List<TaskList>> GetAllByBoardId(int boardId)
        {
            var result = _taskListRepository.GetAll(p => p.BoardId.Equals(boardId));
            return (!(result == null || !result.Any())) ? new SuccessDataResult<List<TaskList>>(result)
                : new ErrorDataResult<List<TaskList>>("Bu panoya bağlı task list yok.");
        }

        public IDataResult<List<TaskListViewDto>> GetAllWithTasks(int boardId)
        {
            var result = _taskListRepository.GetAllWithTasks(boardId);
            return (!(result == null || !result.Any())) ? new SuccessDataResult<List<TaskListViewDto>>(result)
                : new ErrorDataResult<List<TaskListViewDto>>("Bu panoya bağlı task list yok.");
        }

        public IResult Update(TaskList taskList)
        {
            var result = _taskListRepository.Get(p => p.Id.Equals(taskList.Id));
            if (result == null) return new ErrorResult("Güncellenecek görev listesi bulunamadı.");

            result.Name = taskList.Name;
            _taskListRepository.Update(result);
            return new SuccessResult("Güncelleme işlemi başarılı.");
        }

        public IResult UpdateOrder(TaskListUpdateOrderDto taskListUpdateOrder)
        {
            var result = _taskListRepository.Get(p => p.Id.Equals(taskListUpdateOrder.Id));

            if (result == null)
                return new ErrorResult("Güncellenecek görev listesi bulunamadı.");

            result.OrderNo = taskListUpdateOrder.OrderNo;

            _taskListRepository.Update(result);

            return new SuccessResult("İşlem başarılı.");

        }
    }
}
