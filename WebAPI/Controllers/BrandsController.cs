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
	public class BrandsController : Controller
	{
		IBrandService _brandService;

		public BrandsController(IBrandService brandService)
		{
			_brandService = brandService;
		}

		[HttpPost("add")]
		public IActionResult Add(Brand brand)
		{
			var result = _brandService.Add(brand);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("update")]
		public IActionResult Update(Brand brand)
		{
			var result = _brandService.Update(brand);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("delete")]
		public IActionResult Delete(Brand brand)
		{
			var result = _brandService.Delete(brand);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("get")]
		public IActionResult Get(int id)
		{
			var result = _brandService.Get(id);

			if (result.Success)
			{
				return BadRequest(result);
			}

			return Ok(result);
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _brandService.GetAll();

			if (result.Success)
			{
				return Ok(result);
			}

			return BadRequest(result);
		}
	}
}
