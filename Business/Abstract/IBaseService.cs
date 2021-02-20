using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IBaseService<T>
	{
		IDataResult<T> GetById(int id);
		IDataResult<List<T>> GetAll();
		IResult Add(T entity);
		IResult Update(T entity);
		IResult Delete(T entity);
	}
}
