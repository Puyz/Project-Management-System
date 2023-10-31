using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class TaskTodoList : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TaskId { get; set; }
    }
}
