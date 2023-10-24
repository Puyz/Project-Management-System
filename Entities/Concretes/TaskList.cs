using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class TaskList : IEntity
    {
        public int Id { get; set; }
        public int BoardId { get; set; }
        public string? Name { get; set; }
        public int OrderNo { get; set; }

    }
}
