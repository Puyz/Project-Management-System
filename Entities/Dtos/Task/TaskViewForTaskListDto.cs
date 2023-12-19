using Core.Entities.Abstracts;

namespace Entities.Dtos.Task
{
    public class TaskViewForTaskListDto : IDto
    {
        public int Id { get; set; }
        public int TaskListId { get; set; }
        public string Name { get; set; }
        public List<TaskMemberDto> taskMembers { get; set; }
        public List<TaskLabelDto> taskLabels { get; set; }
        public int AttachmentCount { get; set; }
        public int CommentCount { get; set; }
        public int OrderNo { get; set; }
        public DateTime DueDate { get; set; }
    }
}
