using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Dtos.Task;

namespace Business.Concretes
{
    public class TaskManager : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskManager(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public IResult Add(AddTaskDto addTaskDto)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int taskId)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteAll(List<Entities.Concretes.Task> tasks)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Entities.Concretes.Task>> GetAllByTaskListId(int taskListId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<TaskViewDto> GetById(int taskId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(EditTaskDto editTaskDto)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateOrder(TaskOrderEditDto taskOrderEditDto)
        {
            throw new NotImplementedException();
        }
    }
}
