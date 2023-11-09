using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Board;

namespace Business.Abstracts
{
    public interface IBoardService
    {
        IResult Add(Board board);
        IResult Delete(int boardId);
        IResult DeleteAll(List<Board> boards);
        IResult Update(EditBoardDto board);
        IDataResult<List<BoardViewDto>> GetAll(int workspaceId, int userId);
        IDataResult<List<Board>> GetAllByWorkspaceId(int workspaceId);
        IDataResult<BoardViewDto> Get(int boardId);
    }
}
