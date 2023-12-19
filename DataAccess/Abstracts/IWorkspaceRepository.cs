using Core.DataAccess;
using Entities.Concretes;
using Entities.Dtos.Workspace;

namespace DataAccess.Abstracts
{
    public interface IWorkspaceRepository : IEntityRepository<Workspace>
    {
        List<Workspace> GetAllByUserId(int userId);
        WorkspaceViewDto GetById(int workspaceId);
    }
}
