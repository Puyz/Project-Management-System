using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Task;

namespace Business.Concretes
{
    public class TaskTodoListManager : ITaskTodoListService
    {
        public IResult Add(TaskTodoList taskTodoList)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteAll(List<TaskTodoList> taskTodoLists)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TaskTodoList>> GetAllByTaskId(int taskId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TaskTodoListDto>> GetAllWithTodoByTaskId(int taskId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(TaskTodoList taskTodoList)
        {
            throw new NotImplementedException();
        }
    }
}
