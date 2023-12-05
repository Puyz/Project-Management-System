using Core.Entities.Concretes;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class UserValidator: AbstractValidator<User>
	{
		public UserValidator()
		{
            RuleFor(user => user.Email).EmailAddress();

			RuleFor(user => user.Name).NotEmpty();
			RuleFor(user => user.Name).MinimumLength(3);
		}
	}
}

