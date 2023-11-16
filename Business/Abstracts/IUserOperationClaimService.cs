using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using Entities.Dtos;

namespace Business.Abstracts
{
    public interface IUserOperationClaimService
    {
        IResult Add(UserOperationClaim userOperationClaim);
        IResult Delete(int userOperationClaimId);
        IResult Update(UserOperationClaim userOperationClaim);
        IDataResult<List<UserOperationClaim>> GetAll(int userId, int workspaceId);
        IDataResult<List<UserOperationClaimDto>> GetListDto(int userId, int workspaceId);
        IDataResult<UserOperationClaim> GetById(int userOperationClaimId);
    }
}
