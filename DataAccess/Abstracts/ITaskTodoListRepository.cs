using Core.DataAccess;
using Entities.Concretes;
using Entities.Dtos.Task;

namespace DataAccess.Abstracts
{
    public interface ITaskTodoListRepository : IEntityRepository<TaskTodoList>
    {

        List<TaskTodoListDto> GetAllWithTodoByTaskId(int taskId);
    }
}
