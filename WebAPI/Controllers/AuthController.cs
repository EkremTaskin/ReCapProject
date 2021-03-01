using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : Controller
	{
		IAuthService _authService;

		public AuthController(IAuthService authService)
		{
			_authService = authService;
		}

		[HttpPost("login")]
		public IActionResult Login(UserForLoginDto userForLoginDto)
		{
			var UserForLogin = _authService.Login(userForLoginDto);

			if (!UserForLogin.Success)
			{
				return BadRequest(UserForLogin.Message);
			}
			var result = _authService.CreateAccessToken(UserForLogin.Data);

			if (result.Success)
			{
				return Ok(result.Data);
			}

			return BadRequest();
		}

		[HttpPost("register")]
		public IActionResult Register(UserForRegisterDto userForRegisterDto)
		{
			var userExists = _authService.UserExists(userForRegisterDto.Email);

			if (!userExists.Success)
			{
				return BadRequest(userExists.Message);
			}

			var registerResult = _authService.Register(userForRegisterDto , userForRegisterDto.Password);
			var result = _authService.CreateAccessToken(registerResult.Data);

			if (result.Success)
			{
				return Ok(result.Data);
			}

			return BadRequest(result.Message);
		}
	}
}
