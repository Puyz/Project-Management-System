using Core.DataAccess;
using Entities.Concretes;
using Entities.Dtos.Workspace;

namespace DataAccess.Abstracts
{
    public interface IWorkspaceMemberRepository : IEntityRepository<WorkspaceMember>
    {
        List<WorkspaceMemberViewDto> GetAllByWorkspaceIdWithUsers(int workspaceId);
    }
}
