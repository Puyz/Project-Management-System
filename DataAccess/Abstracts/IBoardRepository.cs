using Core.DataAccess;
using Entities.Concretes;
using Entities.Dtos.Board;

namespace DataAccess.Abstracts
{
    public interface IBoardRepository : IEntityRepository<Board>
    {
        List<BoardViewDto> GetAllBoards(int companyId, int userId);
        BoardViewDto GetBoard(int boardId);
    }
}
