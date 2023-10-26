using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class WorkspaceMemberManager : IWorkspaceMemberService
    {
        public IResult Add(List<WorkspaceMember> workspaceMembers)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int workspaceMemberId)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteAll(List<WorkspaceMember> workspaceMembers)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<WorkspaceMember>> GetAllByWorkspaceId(int workspaceId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<WorkspaceMember>> GetAllByWorkspaceIdWithUsers(int boardId)
        {
            throw new NotImplementedException();
        }
    }
}
