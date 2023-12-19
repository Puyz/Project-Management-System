using Core.Entities.Abstracts;

namespace Entities.Dtos.Task
{
    public class TaskMemberDto : IDto
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
    }
}
