using Core.DataAccess;
using Core.Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IUserRepository : IEntityRepository<User>
    {
    }
}
