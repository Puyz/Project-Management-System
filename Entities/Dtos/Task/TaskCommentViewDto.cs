using Core.Entities.Abstracts;

namespace Entities.Dtos.Task
{
    public class TaskCommentViewDto : IDto
    {
        public int Id { get; set; }
        public UserViewDto User { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
