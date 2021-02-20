using Business.Abstract;
using Core.Entities;
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
	public class ServicesController<TService , TEntity> : ControllerBase
		where TService: class , IBaseService<TEntity>
		where TEntity: class , IEntity
	{
		IBaseService<TEntity> _baseService;

		public ServicesController(IBaseService<TEntity> baseService)
		{
			_baseService = baseService;
		}

		[HttpPost("add")]
		public IActionResult Add(TEntity entity)
		{
			var result = _baseService.Add(entity);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("update")]
		public IActionResult Update(TEntity entity)
		{
			var result = _baseService.Update(entity);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("delete")]
		public IActionResult Delete(TEntity entity)
		{
			var result = _baseService.Delete(entity);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _baseService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getbyid")]
		public IActionResult GetById(int id)
		{
			var result = _baseService.GetById(id);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}
