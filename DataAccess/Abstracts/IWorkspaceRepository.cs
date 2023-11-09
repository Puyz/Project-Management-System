using Core.DataAccess;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IWorkspaceRepository : IEntityRepository<Workspace>
    {
        List<Workspace> GetAllByUserId(int userId);
    }
}
