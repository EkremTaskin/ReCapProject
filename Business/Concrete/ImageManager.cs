using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Business;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class ImageManager : IImageService
	{
		IImageDal _imageDal;

		public ImageManager(IImageDal imageDal)
		{
			_imageDal = imageDal;
		}

		public IResult Add(Image entity)
		{
			IResult result = BusinessRules.Run(CheckIfImageLimitExceded(entity));

			if (result != null)
			{
				return result;
			}
			entity.Date = DateTime.Now;
			_imageDal.Add(entity);
			return new SuccessResult(Message.ImageAdded);
		}

		public IResult Delete(Image entity)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Image>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IDataResult<Image> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Image entity)
		{
			throw new NotImplementedException();
		}

		private IResult CheckIfImageLimitExceded(Image image)
		{
			var result = _imageDal.GetAll(c=>c.CarId == image.CarId).Count;

			if (result >= 5)
			{
				return new ErrorResult(Message.ImageLimitExceded);
			}

			return new SuccessResult();
		}

	}
}
