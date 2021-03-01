using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarsController : Controller
	{
        ICarService _carService;

		public CarsController(ICarService carService)
		{
			_carService = carService;
		}

		[HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

		[HttpPost("update")]
		public IActionResult Update(Car car)
		{
			var result = _carService.Update(car);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		//[HttpPost("delete")]
		//public IActionResult Delete(CarImage image)
		//{
		//    var result = _imageService.Delete(image);
		//    if (result.Success)
		//    {
		//        return Ok(result);
		//    }
		//    return BadRequest(result);
		//}
	}
}
