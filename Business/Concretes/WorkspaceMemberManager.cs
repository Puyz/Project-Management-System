using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Workspace;

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

        public IDataResult<List<WorkspaceMemberViewDto>> GetAllByWorkspaceId(int workspaceId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<WorkspaceMemberViewDto>> GetAllByWorkspaceIdWithUsers(int boardId)
        {
            throw new NotImplementedException();
        }
    }
}
