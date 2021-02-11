using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ICustomerService
	{
		IDataResult<Customer> Get(int id);
		IDataResult<List<Customer>> GetAll();
		IResult Add(Customer customer);

		IResult Update(Customer customer);

		IResult Delete(Customer customer);
	}
}
