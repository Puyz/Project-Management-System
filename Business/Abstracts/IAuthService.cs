using System;
using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Security.JWT;
using Entities.Dtos.Auth;

namespace Business.Abstracts
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}

