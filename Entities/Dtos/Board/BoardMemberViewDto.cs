﻿namespace Entities.Dtos.Board
{
    public class BoardMemberViewDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
    }
}
