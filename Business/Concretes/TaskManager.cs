using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class TaskManager : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskManager(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public IResult Add(Entities.Concretes.Task taskDto)
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

        public IDataResult<Entities.Concretes.Task> GetById(int taskId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Entities.Concretes.Task taskDto)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateOrder(Entities.Concretes.Task taskOrderEditDto)
        {
            throw new NotImplementedException();
        }
    }
}
