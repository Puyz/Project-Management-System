using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class TaskListManager : ITaskListService
    {
        private readonly ITaskListRepository _taskListRepository;

        public TaskListManager(ITaskListRepository taskListRepository)
        {
            _taskListRepository = taskListRepository;
        }
        public IResult Add(TaskList taskList)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int taskListId)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteAll(List<TaskList> taskLists)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TaskList>> GetAllByBoardId(int boardId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TaskList>> GetAllWithTasks(int boardId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(TaskList taskList)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateOrder(int taskListId, int orderNo)
        {
            throw new NotImplementedException();
        }
    }
}
