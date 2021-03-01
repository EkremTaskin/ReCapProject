using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
	public class UserValidator : AbstractValidator<User>
	{
		public UserValidator()
		{
			RuleFor(u => u.Email).Must(ContainsAt).WithMessage("EMail Invalid");
			RuleFor(u => u.FirstName).NotEmpty();
		}

		private bool ContainsAt(string arg)
		{
			return arg.Contains("@");
		}
	}
}
