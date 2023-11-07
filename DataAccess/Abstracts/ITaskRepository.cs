using Core.DataAccess;
using Entities.Dtos.Task;
using Task = Entities.Concretes.Task;

namespace DataAccess.Abstracts
{
    public interface ITaskRepository : IEntityRepository<Task>
    {
        TaskViewDto GetTaskByTaskId(int taskId);
    }
}
