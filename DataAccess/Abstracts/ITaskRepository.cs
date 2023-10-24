using Core.DataAccess;
using Task = Entities.Concretes.Task;

namespace DataAccess.Abstracts
{
    public interface ITaskRepository : IEntityRepository<Task>
    {
    }
}
