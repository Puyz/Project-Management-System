﻿using Business.Abstracts;
using Core.Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var userExist = _userService.UserExists(user.Email);
            if (!userExist.Success) return BadRequest(userExist.Message);

            var result = _userService.Add(user);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _userService.GetUserById(id);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
        [HttpGet("getByName")]
        public IActionResult GetByName(string name)
        {
            var result = _userService.GetAllByName(name);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
    }
}
