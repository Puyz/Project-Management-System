using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Board;

namespace Business.Concretes
{
    public class BoardManager : IBoardService
    {
        private readonly IBoardRepository _boardRepository;
        private readonly ITaskListService _taskListService;
        private readonly IBoardMemberService _boardMemberService;

        public BoardManager(IBoardRepository boardRepository, ITaskListService taskListService, IBoardMemberService boardMemberService)
        {
            _boardRepository = boardRepository;
            _taskListService = taskListService;
            _boardMemberService = boardMemberService;
        }

        public IResult Add(Board board)
        {
            _boardRepository.Add(board);
            return new SuccessResult("Pano oluşturuldu.");
        }

        public IResult Delete(int boardId)
        {
            var removedBoard = _boardRepository.Get(p => p.Id.Equals(boardId));

            if (removedBoard == null) return new ErrorResult("Silinecek pano bulunamadı.");

            var removedTaskLists = _taskListService.GetAllByBoardId(boardId).Data;
            var removedBoardMembers = _boardMemberService.GetAllByBoardId(boardId).Data;

            if (removedTaskLists != null)
            {
                _taskListService.DeleteAll(removedTaskLists);
            }
            if (removedBoardMembers != null)
            {
                _boardMemberService.DeleteAll(removedBoardMembers);
            }

            _boardRepository.Delete(removedBoard);
            return new SuccessResult("Pano silindi.");
        }

        public IResult DeleteAll(List<Board> boards)
        {
            if(boards == null || !boards.Any()) { return new ErrorResult("Silinecek panolar bulunamadı."); }
            foreach (var board in boards)
            {
                Delete(board.Id);
            }
            return new SuccessResult();
        }

        public IDataResult<BoardViewDto> Get(int boardId)
        {
            var result = _boardRepository.GetBoard(boardId);
            return (result != null) ? new SuccessDataResult<BoardViewDto>(result) : new ErrorDataResult<BoardViewDto>("Pano bulunamadı.");
        }

        public IDataResult<List<BoardViewDto>> GetAll(int workspaceId, int userId)
        {
            var result = _boardRepository.GetAllBoards(workspaceId, userId);
            return (!(result == null || !result.Any())) ? new SuccessDataResult<List<BoardViewDto>>(result) : new ErrorDataResult<List<BoardViewDto>>("Bu şirkete bağlı pano yok.");
        }

        public IDataResult<List<Board>> GetAllByWorkspaceId(int workspaceId)
        {
            var result = _boardRepository.GetAll(b => b.WorkspaceId.Equals(workspaceId));
            return new SuccessDataResult<List<Board>>(result);
        }

        public IResult Update(EditBoardDto board)
        {
            var updatedBoard = _boardRepository.Get(p => p.Id.Equals(board.Id));
            if (updatedBoard == null) return new ErrorResult("Güncellenecek pano bulunamadı.");

            updatedBoard.Name = board.Name!;
            updatedBoard.PrivateToWorkspaceMember = board.PrivateToWorkspaceMember;
            updatedBoard.EndDate = board.EndDate;
            _boardRepository.Update(updatedBoard);
            return new SuccessResult("Pano güncellendi.");
        }

    }
}
