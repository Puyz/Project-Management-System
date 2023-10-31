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

        public BoardManager(IBoardRepository boardRepository) {
            _boardRepository = boardRepository;
        }

        public IResult Add(Board board)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int boardId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<BoardViewDto> Get(int boardId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BoardViewDto>> GetAll(int workspaceId, int userId)
        {
            var result = _boardRepository.GetAll();
            if (result == null) return new ErrorDataResult<List<BoardViewDto>>();
            return new SuccessDataResult<List<BoardViewDto>>("Listelendi");
        }

        public IResult Update(Board board)
        {
            throw new NotImplementedException();
        }

    }
}
