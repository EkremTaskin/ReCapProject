using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
	public class CustomerValidator : AbstractValidator<Customer>
	{
		public CustomerValidator()
		{
			RuleFor(cu => cu.CompanyName).MinimumLength(2);
			RuleFor(cu => cu.UserId).NotNull();
			RuleFor(cu => cu.UserId).NotEmpty();
		}
	}
}
