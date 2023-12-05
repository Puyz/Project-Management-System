using System;
using Core.Entities.Concretes;

namespace Core.Utilities.Security.JWT
{
	public interface ITokenHelper
	{
		AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
	}
}

