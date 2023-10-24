using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Context;
using Task = Entities.Concretes.Task;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfTaskRepository : EfEntityRepositoryBase<Task, PMSContext>, ITaskRepository
    {
    }
}
