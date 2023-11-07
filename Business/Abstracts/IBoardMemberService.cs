using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Board;

namespace Business.Abstracts
{
    public interface IBoardMemberService
    {
        IResult Add(List<BoardMember> boardMembers);
        IResult Delete(int boardMemberId);
        IResult DeleteAll(List<BoardMember> boardMembers);
        IDataResult<List<BoardMember>> GetAllByBoardId(int boardId);
        IDataResult<List<BoardMemberViewDto>> GetAllByBoardIdWithUsers(int boardId);
    }
}
