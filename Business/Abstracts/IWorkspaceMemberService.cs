using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IWorkspaceMemberService
    {
        IResult Add(List<WorkspaceMember> workspaceMembers);
        IResult Delete(int workspaceMemberId);
        IResult DeleteAll(List<WorkspaceMember> workspaceMembers);
        IDataResult<List<WorkspaceMember>> GetAllByWorkspaceId(int workspaceId);
        IDataResult<List<WorkspaceMember>> GetAllByWorkspaceIdWithUsers(int boardId); // WorkspaceMember dto

    }
}