using Entities.Dtos.Task;

namespace Entities.Dtos.TaskList
{
    public class TaskListViewDto
    {
        public int Id { get; set; }
        public int BoardId { get; set; }
        public string Name { get; set; }
        public int OrderNo { get; set; }
        public List<TaskViewForTaskListDto>? Tasks { get; set; }
    }
}
