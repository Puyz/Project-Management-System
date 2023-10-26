using Business.Abstracts;
using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        private readonly IUserOperationClaimRepository _userOperationClaimRepository;
        public UserOperationClaimManager(IUserOperationClaimRepository userOperationClaimRepository)
        {
            _userOperationClaimRepository = userOperationClaimRepository;
        }

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
