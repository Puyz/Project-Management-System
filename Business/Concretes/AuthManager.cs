using System;
using Business.Abstracts;
using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.Dtos.Auth;

namespace Business.Concretes
{
	public class AuthManager : IAuthService
	{
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
		public AuthManager(IUserService userService, ITokenHelper tokenHelper)
		{
            _userService = userService;
            _tokenHelper = tokenHelper;
		}

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user).Data;
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "Token oluşturuldu");
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var user =  _userService.GetByMail(userForLoginDto.Email).Data;
            if (user == null) return new ErrorDataResult<User>("Kullanıcı adı veya şifre hatalı");

            var verifyPassword = HashingHelper.VerifyPasswordHash(userForLoginDto.Password, user.PasswordHash, user.PasswordSalt);
            if (!verifyPassword) return new ErrorDataResult<User>("Kullanıcı adı veya şifre hatalı");

            return new SuccessDataResult<User>(user, "Giriş başarılı");
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                Name = userForRegisterDto.Name,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                CreatedDate = DateTime.Now
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, "Kullanıcı oluşturuldu");

        }

        public IResult UserExists(string email)
        {
            var result = _userService.GetByMail(email);
            if (result.Success)
            {
                return new ErrorResult("Kullanıcı zaten mevcut");
            }
            return new SuccessResult();
        }
    }
}

