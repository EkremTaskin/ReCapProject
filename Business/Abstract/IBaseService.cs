using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IBaseService<T>
	{
		IDataResult<T> Get(int id);
		IDataResult<List<T>> GetAll();
		IResult Add(T brand);
		IResult Update(T brand);
		IResult Delete(T brand);
	}
}
