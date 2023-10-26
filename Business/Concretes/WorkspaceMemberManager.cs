using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class WorkspaceMemberManager : IWorkspaceMemberService
    {
        private readonly IWorkspaceMemberRepository _workspaceMemberRepository;
        public WorkspaceMemberManager(IWorkspaceMemberRepository workspaceMemberRepository) 
        {
            _workspaceMemberRepository = workspaceMemberRepository;
        }
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
