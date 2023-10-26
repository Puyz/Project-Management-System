using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class BoardMemberManager : IBoardMemberService
    {
        private readonly IBoardMemberRepository _boardMemberRepository;
        public BoardMemberManager(IBoardMemberRepository boardMemberRepository) { 
            _boardMemberRepository = boardMemberRepository;
        }
        public IResult Add(BoardMember boardMember)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int boardMemberId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<BoardMember> Get(int boardMemberId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BoardMember>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(BoardMember boardMember)
        {
            throw new NotImplementedException();
        }
    }
}
