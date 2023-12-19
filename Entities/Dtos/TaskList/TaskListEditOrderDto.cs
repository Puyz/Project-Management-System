using Core.Entities.Abstracts;

namespace Entities.Dtos.TaskList
{
    public class TaskListEditOrderDto : IDto
    {
        public int Id { get; set; }
        public int OrderNo { get; set; }
    }
}
