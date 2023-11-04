using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class TaskTodoManager : ITaskTodoService
    {
        public IResult Add(TaskTodo taskTodo)
        {
            throw new NotImplementedException();
        }

        public IResult Change(int id, bool state)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteAll(List<TaskTodo> taskTodos)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TaskTodo>> GetAllByTodoListId(int todoListId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(TaskTodo taskTodo)
        {
            throw new NotImplementedException();
        }
    }
}
