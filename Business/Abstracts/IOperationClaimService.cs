using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;

namespace Business.Abstracts
{
    public interface IOperationClaimService
    {
        IResult Add(OperationClaim operationClaim);
        IResult Delete(int operationClaimId);
        IResult Update(OperationClaim operationClaim);
        IDataResult<List<OperationClaim>> GetAll();
        IDataResult<OperationClaim> GetById(int operationClaimId);
    }
}
