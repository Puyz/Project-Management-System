using System;
using Core.Entities.Abstracts;

namespace Entities.Dtos.Auth
{
    public class UserForRegisterDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}

