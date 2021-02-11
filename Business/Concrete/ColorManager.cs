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
			_colorDal.Add(color);
			return new SuccessResult();
		}

		public IResult Delete(Color color)
		{
			_colorDal.Delete(color);
			return new SuccessResult();
		}

		public IDataResult<Color> Get(int id)
		{
			return new SuccessDataResult<Color>(_colorDal.GetById(p=>p.Id == id));
		}

		public IDataResult<List<Color>> GetAll()
		{
			return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
		}

		public IResult Update(Color color)
		{
			_colorDal.Update(color);
			return new SuccessResult();
		}
	}
}
