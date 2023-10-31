using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class TaskTodo : IEntity
    {
        public int Id { get; set; }
        public int TaskTodoListId { get; set; }
        public string Content { get; set; }
        public bool State { get; set; }
    }
}
