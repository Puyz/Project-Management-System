using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Workspace;

namespace Business.Abstracts
{
    public interface IWorkspaceMemberService
    {
        IResult Add(List<WorkspaceMember> workspaceMembers);
        IResult Delete(int workspaceMemberId);
        IResult DeleteAll(List<WorkspaceMember> workspaceMembers);
        IDataResult<List<WorkspaceMember>> GetAllByWorkspaceId(int workspaceId);
        IDataResult<List<WorkspaceMemberViewDto>> GetAllByWorkspaceIdWithUsers(int workspaceId);

    }
}