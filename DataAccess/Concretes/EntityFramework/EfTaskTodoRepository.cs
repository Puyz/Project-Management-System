using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfTaskTodoRepository : EfEntityRepositoryBase<TaskTodo, PMSContext>, ITaskTodoRepository
    {
    }
}
