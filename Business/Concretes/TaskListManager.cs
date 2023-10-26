using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class TaskListManager : ITaskListService
    {
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
