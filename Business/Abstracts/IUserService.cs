using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using Entities.Dtos;

namespace Business.Abstracts
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IDataResult<List<UserViewDto>> GetAll();
        IDataResult<List<UserViewDto>> GetAllByName(string name);
        IDataResult<User> GetByMail(string email);
        IDataResult<UserViewDto> GetUserById(int id);
        IDataResult<List<OperationClaim>> GetClaims(User user);
    }
}
