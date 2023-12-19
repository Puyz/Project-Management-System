using Core.Entities.Abstracts;

namespace Entities.Dtos.Task
{
    public class TaskOrderEditDto : IDto
    {
        public int Id { get; set; }
        public int TaskListId { get; set; }
        public int OrderNo { get; set; }
    }
}
