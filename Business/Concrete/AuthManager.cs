using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class AuthManager : IAuthService
	{
		IUserService _userService;
		ITokenHelper _tokenHelper;
		public AuthManager(IUserService userService, ITokenHelper tokenHelper)
		{
			_userService = userService;
			_tokenHelper = tokenHelper;
		}

		public IDataResult<AccessToken> CreateAccessToken(User user)
		{
			var claims = _userService.GetClaims(user);
			var accessToken = _tokenHelper.CreateToken(user , claims.Data);
			return new SuccessDataResult<AccessToken>(accessToken,Messages.AccessTokenCreated);
		}

		public IDataResult<User> Login(UserForLoginDto userForLoginDto)
		{
			var userToCheck = _userService.GetByMail(userForLoginDto.Email);

			if (userToCheck.Data == null)
			{
				return new ErrorDataResult<User>(Messages.UserNotFound);
			}

			if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
			{
				return new ErrorDataResult<User>(Messages.PasswordError);
			}

			return new SuccessDataResult<User>(userToCheck.Data, Messages.SuccessFullLogin);
		}

		
		public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
		{
			byte[] passwordHash, passwordSalt;
			HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
			var user = new User
			{
				Email = userForRegisterDto.Email,
				FirstName = userForRegisterDto.FirstName,
				LastName = userForRegisterDto.LastName,
				PasswordHash = passwordHash,
				PasswordSalt = passwordSalt,
				Status = true
			};
			_userService.Add(user);
			return new SuccessDataResult<User>(user , Messages.UserRegistered);
		}

		public IResult UserExists(string email)
		{
			var result = _userService.GetByMail(email);

			if (result.Data != null)
			{
				return new ErrorResult(Messages.UserAlreadyExists);
			}

			return new SuccessResult();
		}
	}
}
