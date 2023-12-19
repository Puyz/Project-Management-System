using Core.Entities.Abstracts;

namespace Entities.Dtos.Task
{
    public class TaskViewDto : IDto
    {
        public Concretes.Task Task { get; set; }
        public List<TaskMemberDto>? TaskMembers { get; set; }
        public List<TaskLabelDto>? TaskLabels { get; set; }
    }
}
