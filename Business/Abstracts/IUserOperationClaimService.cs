using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;

namespace Business.Abstracts
{
    public interface IUserOperationClaimService
    {
        IResult Add(UserOperationClaim userOperationClaim);
        IResult Delete(UserOperationClaim userOperationClaim);// maybe with id
        IDataResult<List<UserOperationClaim>> GetAllByUserId(int userId);
        IDataResult<UserOperationClaim> Get(int userOperationClaimId);

    }
}
