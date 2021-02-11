using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class ColorManager : IColorService
	{
		IColorDal _colorDal;
		public ColorManager(IColorDal colorDal)
		{
			_colorDal = colorDal;
		}

		public IResult Add(Color color)
		{
			throw new NotImplementedException();
		}

		public IResult Delete(Color color)
		{
			throw new NotImplementedException();
		}

		public IDataResult<Color> Get(int id)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Color>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IResult Update(Color color)
		{
			throw new NotImplementedException();
		}
	}
}
