using Core.DataAccess;
using Entities.Concretes;
using Entities.Dtos.Board;

namespace DataAccess.Abstracts
{
    public interface IBoardMemberRepository : IEntityRepository<BoardMember>
    {
        List<BoardMemberViewDto> GetAllByBoardIdWithUsers(int boardId);
    }
}
