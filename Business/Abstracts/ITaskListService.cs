using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.Dtos.TaskList;

namespace Business.Abstracts
{
    public interface ITaskListService
    {
        IResult Add(TaskList taskList);
        IResult Delete(int taskListId);
        IResult DeleteAll(List<TaskList> taskLists);
        IResult Update(TaskList taskList);
        IResult UpdateOrder(TaskListUpdateOrderDto taskListUpdateOrder);
        IDataResult<List<TaskList>> GetAllByBoardId(int boardId);
        IDataResult<List<TaskListViewDto>> GetAllWithTasks(int boardId);
    }
}
