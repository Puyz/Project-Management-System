using System;
using Core.Entities.Abstracts;

namespace Entities.Dtos.Auth
{
	public class UserForLoginDto : IDto
	{
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

