using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
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
            if ((workspaceMembers == null || !workspaceMembers.Any())) return new ErrorResult("Çalışma alanına atanacak kullanıcılar bulunamadı.");
            foreach (var workspaceMember in workspaceMembers)
            {
                _workspaceMemberRepository.Add(workspaceMember);
            }
            return new SuccessResult("Çalışma alanına kullanıcılar atandı.");
        }

        public IResult Delete(int workspaceMemberId)
        {
            var result = _workspaceMemberRepository.Get(p => p.Id.Equals(workspaceMemberId));
            if (result == null) return new ErrorResult("Silmek için çalışma alanına atanmış kullanıcı bulunamadı.");
            _workspaceMemberRepository.Delete(result);
            return new SuccessResult("Çalışma alanına atanmış kullanıcı kaldırıldı.");
        }

        public IResult DeleteAll(List<WorkspaceMember> workspaceMembers)
        {
            if ((workspaceMembers == null || !workspaceMembers.Any())) return new ErrorResult("Silmek için çalışma alanına atanmış kullanıcılar bulunamadı.");
            foreach (var workspaceMember in workspaceMembers)
            {
                Delete(workspaceMember.Id);
            }
            return new SuccessResult();
        }

        public IDataResult<List<WorkspaceMember>> GetAllByWorkspaceId(int workspaceId)
        {
            var result = _workspaceMemberRepository.GetAll(wm => wm.WorkspaceId.Equals(workspaceId));
            return new SuccessDataResult<List<WorkspaceMember>>(result);
        }

        public IDataResult<List<WorkspaceMemberViewDto>> GetAllByWorkspaceIdWithUsers(int workspaceId)
        {
            var result = _workspaceMemberRepository.GetAllByWorkspaceIdWithUsers(workspaceId);
            return new SuccessDataResult<List<WorkspaceMemberViewDto>>(result);
        }
    }
}
