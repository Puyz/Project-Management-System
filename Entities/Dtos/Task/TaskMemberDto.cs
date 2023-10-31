namespace Entities.Dtos.Task
{
    public class TaskMemberDto
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
    }
}
