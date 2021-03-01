using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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

		public IResult Add(IFormFile File, CarImage carImage)
		{
			IResult result = BusinessRules.Run(CheckIfImageLimitExceded(carImage));

			if (result != null)
			{
				return result;
			}

			carImage.ImagePath = FileHelper.Add(File);
			carImage.Date = DateTime.Now;
			_imageDal.Add(carImage);
			return new SuccessResult(Message.ImageAdded);
		}

		public IResult Delete(CarImage entity)
		{
			_imageDal.Delete(entity);
			return new SuccessResult(Message.CarImageDeleted);
		}

		public IDataResult<CarImage> Get(int id)
		{
			return new SuccessDataResult<CarImage>(_imageDal.Get(i => i.Id == id));
		}

		public IDataResult<List<CarImage>> GetAll()
		{
			return new SuccessDataResult<List<CarImage>>(_imageDal.GetAll());
		}

		public IDataResult<List<CarImage>> GetByCarIdImages(int id)
		{
			var result = _imageDal.GetAll(i => i.CarId == id);
			if (result.Count > 0)
			{
				return new SuccessDataResult<List<CarImage>>(result);
			}
			return new ErrorDataResult<List<CarImage>>(Message.Error);
		}

		public IDataResult<CarImage> GetById(int id)
		{
			return new SuccessDataResult<CarImage>(_imageDal.GetById(i => i.Id == id));
		}

		public IResult Update(CarImage entity)
		{
			_imageDal.Update(entity);
			return new SuccessResult();
		}

		private IResult CheckIfImageLimitExceded(CarImage image)
		{
			var result = _imageDal.GetAll(c => c.CarId == image.CarId).Count;

			if (result >= 5)
			{
				return new ErrorResult(Message.ImageLimitExceded);
			}

			return new SuccessResult();
		}

	}
}
