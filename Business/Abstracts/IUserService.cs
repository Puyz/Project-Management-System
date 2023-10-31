﻿using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using Entities.Dtos;

namespace Business.Abstracts
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IDataResult<List<UserViewDto>> GetAll();
        IDataResult<List<UserViewDto>> GetByName(string name);
        IDataResult<UserViewDto> GetByMail(string email);
        IDataResult<UserViewDto> GetUserById(long id);
        IResult UserExists(string email);
    }
}
