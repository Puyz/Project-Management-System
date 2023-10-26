using Business.Abstracts;
using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;

namespace Business.Concretes
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        public IResult Add(UserOperationClaim userOperationClaim)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(UserOperationClaim userOperationClaim)
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserOperationClaim> Get(int userOperationClaimId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserOperationClaim>> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
