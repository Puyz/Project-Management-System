using Business.Abstracts;
using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Dtos;

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

        public IResult Delete(int userOperationClaimId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserOperationClaim>> GetAll(int userId, int workspaceId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserOperationClaim> GetById(int userOperationClaimId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserOperationClaimDto>> GetListDto(int userId, int workspaceId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(UserOperationClaim userOperationClaim)
        {
            throw new NotImplementedException();
        }
    }
}
