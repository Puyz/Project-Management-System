using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class TaskMember : IEntity
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
    }
}
