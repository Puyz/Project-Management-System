using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ITaskListService
    {
        IResult Add(TaskList taskList);
        IResult Delete(int taskListId);
        IResult DeleteAll(List<TaskList> taskLists);
        IResult Update(TaskList taskList);
        IResult UpdateOrder(int taskListId, int orderNo);
        IDataResult<List<TaskList>> GetAllByBoardId(int boardId);
        IDataResult<List<TaskList>> GetAllWithTasks(int boardId); // task list dto
    }
}
