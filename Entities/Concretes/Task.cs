using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class Task : IEntity
    {
        public int Id { get; set; }
        public int TaskListId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int OrderNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
