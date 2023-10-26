using Business.Abstracts;
using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }
        public IResult Add(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> GetByMail(string email)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<User>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<OperationClaim> GetOperationClaims(User user, int workspaceId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> GetUserById(long id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(User user)
        {
            throw new NotImplementedException();
        }

        public IResult UserExists(string email)
        {
            throw new NotImplementedException();
        }
    }
}
