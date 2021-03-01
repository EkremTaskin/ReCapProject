using Core.Entities.Concrete;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IUserService
	{
		IDataResult<List<User>> GetAll();
		IDataResult<User> Get(int id);
		IResult Add(User user);
		IResult Update(User user);
		IResult Delete(User user);

		IDataResult<List<OperationClaim>> GetClaims(User user);

		IDataResult<User> GetByMail(string email);
	}
}
