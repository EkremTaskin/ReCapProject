﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
	public class BrandValidator: AbstractValidator<Brand>
	{
		public BrandValidator()
		{
			RuleFor(b => b.Name).NotNull();
			RuleFor(b => b.Name).NotEmpty();

		}
	}
}
