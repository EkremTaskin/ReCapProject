﻿using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IRentalService
	{
		IDataResult<Rental> Get(int id);
		IDataResult<List<Rental>> GetAll();
		IResult Add(Rental rental);

		IResult Update(Rental rental);

		IResult Delete(Rental rental);

	}
}
