using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Task;

namespace Business.Abstracts
{
    public interface ITaskTodoListService
    {
        IResult Add(TaskTodoList taskTodoList);
        IResult Delete(int id);
        IResult DeleteAll(List<TaskTodoList> taskTodoLists);
        IResult Update(TaskTodoList taskTodoList);
        IDataResult<List<TaskTodoList>> GetAllByTaskId(int taskId);
        IDataResult<List<TaskTodoListDto>> GetAllWithTodoByTaskId(int taskId);
    }
}
