using Core.DataAccess.EntityFramework;
using Core.Entities.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Context;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfOperationClaimRepository : EfEntityRepositoryBase<OperationClaim, PMSContext>, IOperationClaimRepository
    {
    }
}
