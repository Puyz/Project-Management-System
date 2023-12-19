using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Workspace;

namespace Business.Concretes
{
    public class WorkspaceManager : IWorkspaceService
    {
        private readonly IWorkspaceRepository _workspaceRepository;
        private readonly IWorkspaceMemberService _workspaceMemberService;
        private readonly IBoardService _boardService;
        public WorkspaceManager(IWorkspaceRepository workspaceRepository, IWorkspaceMemberService workspaceMemberService, IBoardService boardService)
        {
            _workspaceRepository = workspaceRepository;
            _workspaceMemberService = workspaceMemberService;
            _boardService = boardService;
        }
        public IResult Add(Workspace workspace)
        {
            _workspaceRepository.Add(workspace);
            return new SuccessResult("Çalışma alanı eklendi.");
        }

        public IResult Delete(int workspaceId)
        {
            var result = _workspaceRepository.Get(w => w.Id.Equals(workspaceId));

            var members = _workspaceMemberService.GetAllByWorkspaceId(workspaceId).Data;
            if (members != null)
            {
                _workspaceMemberService.DeleteAll(members);
            }

            var boards = _boardService.GetAllByWorkspaceId(workspaceId).Data;
            if (boards != null)
            {
                _boardService.DeleteAll(boards);
            }

            _workspaceRepository.Delete(result);

            return new SuccessResult("Çalışma alanı silindi.");

        }

        public IDataResult<List<Workspace>> GetAllByUserId(int userId)
        {
            var result = _workspaceRepository.GetAllByUserId(userId);
            return new SuccessDataResult<List<Workspace>>(result);
        }

        public IDataResult<WorkspaceViewDto> GetById(int workspaceId)
        {
            var result = _workspaceRepository.GetById(workspaceId);
            if (result == null) return new ErrorDataResult<WorkspaceViewDto>("Çalışma alanı bulunamadı.");
            return new SuccessDataResult<WorkspaceViewDto>(result);
        }

        public IResult Update(Workspace workspace)
        {
            var result = _workspaceRepository.Get(w => w.Id.Equals(workspace.Id));
            if (result == null) return new ErrorResult("Güncellenecek çalışma alanı bulunamadı.");
            _workspaceRepository.Update(workspace);
            return new SuccessResult("Güncellendi.");
        }
    }
}
