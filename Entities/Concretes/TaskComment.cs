using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class TaskComment : IEntity
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
