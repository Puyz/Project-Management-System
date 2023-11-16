using Business.Abstracts;
using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class OperationClaimManager : IOperationClaimService
    {
        private readonly IOperationClaimRepository _operationClaimRepository;

        public OperationClaimManager(IOperationClaimRepository operationClaimRepository)
        {
            _operationClaimRepository = operationClaimRepository;
        }
        public IResult Add(OperationClaim operationClaim)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int operationClaimId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<OperationClaim>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<OperationClaim> GetById(int operationClaimId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(OperationClaim operationClaim)
        {
            throw new NotImplementedException();
        }
    }
}
