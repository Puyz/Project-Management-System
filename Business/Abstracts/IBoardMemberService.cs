using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IBoardMemberService
    {
        IResult Add(BoardMember boardMember);
        IResult Delete(int boardMemberId);
        IResult Update(BoardMember boardMember);
        IDataResult<List<BoardMember>> GetAll();
        IDataResult<BoardMember> Get(int boardMemberId);
    }
}
