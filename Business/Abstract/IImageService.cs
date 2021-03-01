using Core.Utilities;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IImageService
	{
		IDataResult<List<CarImage>> GetAll();
		IDataResult<CarImage> Get(int id);
		IResult Add(IFormFile File, CarImage carImage);
		IResult Update(CarImage image);
		IResult Delete(CarImage image);

		IDataResult<List<CarImage>> GetByCarIdImages(int id);
	}
}
