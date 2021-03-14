using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RentalsController : Controller
	{
		IRentalService _rentalService;

		public RentalsController(IRentalService rentalService)
		{
			_rentalService = rentalService;
		}

		[HttpPost("add")]
		public IActionResult Add(Rental rental)
		{
			var result = _rentalService.Add(rental);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("update")]
		public IActionResult Update(Rental rental)
		{
			var result = _rentalService.Update(rental);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("delete")]
		public IActionResult Delete(Rental rental)
		{
			var result = _rentalService.Delete(rental);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("get")]
		public IActionResult Get(int id)
		{
			var result = _rentalService.Get(id);

			if (result.Success)
			{
				return Ok(result);
			}

			return BadRequest(result);
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _rentalService.GetAll();

			if (result.Success)
			{
				return Ok(result);
			}

			return BadRequest(result);
		}


		[HttpGet("getrentaldetails")]
		public IActionResult GetRentalDetails()
		{
			var result = _rentalService.GetRentalDetails();

			if (result.Success)
			{
				return Ok(result);
			}

			return BadRequest(result);
		}
	}
}
