namespace Entities.Dtos.Task
{
    public class TaskViewDto
    {
        public Concretes.Task Task { get; set; }
        public List<TaskMemberDto>? TaskMembers { get; set; }
        public List<TaskLabelDto>? TaskLabels { get; set; }
    }
}
