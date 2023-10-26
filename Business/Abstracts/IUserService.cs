using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;

namespace Business.Abstracts
{
    public interface IUserService
    {
        List<OperationClaim> GetOperationClaims(User user, int workspaceId);
        IResult Add(User user);
        IResult Update(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetByName(string name); // user dto
        IDataResult<User> GetByMail(string email);
        IDataResult<User> GetUserById(long id);
        //User GetByConfirmValue(string value);
        IResult UserExists(string email);
    }
}
