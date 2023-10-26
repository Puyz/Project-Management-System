using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

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

        public IDataResult<Board> Get(int boardId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Board>> GetAll(int workspaceId, int userId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Board board)
        {
            throw new NotImplementedException();
        }
    }
}
