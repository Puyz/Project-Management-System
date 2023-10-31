using Business.Abstracts;
using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Dtos;

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

        public IDataResult<List<UserViewDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserViewDto> GetByMail(string email)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserViewDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserViewDto> GetUserById(long id)
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
