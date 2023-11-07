using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Board;

namespace Business.Concretes
{
    public class BoardMemberManager : IBoardMemberService
    {
        private readonly IBoardMemberRepository _boardMemberRepository;
        public BoardMemberManager(IBoardMemberRepository boardMemberRepository) { 
            _boardMemberRepository = boardMemberRepository;
        }


        public IResult Add(List<BoardMember> boardMembers)
        {
            if ((boardMembers == null || !boardMembers.Any())) return new ErrorResult("Panoya atanacak kullanıcılar bulunamadı.");
            foreach (var boardMember in boardMembers)
            {
                _boardMemberRepository.Add(boardMember);
            }
            return new SuccessResult("Panoya kullanıcılar atandı.");
        }

        public IResult Delete(int boardMemberId)
        {
            var result = _boardMemberRepository.Get(p => p.Id.Equals(boardMemberId));
            if (result == null) return new ErrorResult("Silmek için panoya atanmış kullanıcı bulunamadı.");
            _boardMemberRepository.Delete(result);
            return new SuccessResult("Panoya atanmış kullanıcı kaldırıldı.");
        }

        public IResult DeleteAll(List<BoardMember> boardMembers)
        {
            if ((boardMembers == null || !boardMembers.Any())) return new ErrorResult("Silmek için panoya atanmış kullanıcılar bulunamadı.");
            foreach (var boardMember in boardMembers)
            {
                Delete(boardMember.Id);
            }
            return new SuccessResult();
        }

        public IDataResult<List<BoardMember>> GetAllByBoardId(int boardId)
        {
            var result = _boardMemberRepository.GetAll(p => p.BoardId.Equals(boardId));
            return new SuccessDataResult<List<BoardMember>>(result);
        }

        public IDataResult<List<BoardMemberViewDto>> GetAllByBoardIdWithUsers(int boardId)
        {
            var result = _boardMemberRepository.GetAllByBoardIdWithUsers(boardId);
            return new SuccessDataResult<List<BoardMemberViewDto>>(result);
        }
    }
}
