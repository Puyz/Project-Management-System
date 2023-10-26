using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IBoardService
    {
        IResult Add(Board board);
        IResult Delete(int boardId);
        IResult Update(Board board);
        IDataResult<List<Board>> GetAll(int workspaceId, int userId);
        IDataResult<Board> Get(int boardId);
    }
}
