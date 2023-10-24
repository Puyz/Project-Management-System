using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class TaskLabel : IEntity
    {
        public int Id { get; set; } 
        public int TaskId { get; set; }
        public int LabelId { get; set; }
    }
}
