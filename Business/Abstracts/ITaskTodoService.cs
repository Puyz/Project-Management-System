using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ITaskTodoService
    {
        IResult Add(TaskTodo taskTodo);
        IResult Delete(int id);
        IResult Update(TaskTodo taskTodo);
        IResult Change(int id, bool state);
        IResult DeleteAll(List<TaskTodo> taskTodos);
        IDataResult<List<TaskTodo>> GetAllByTodoListId(int todoListId);
    }
}
