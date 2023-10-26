using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class BoardManager : IBoardService
    {
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
