
namespace Entities.Dtos.Task
{
    public class EditTaskDto : AddTaskDto
    {
        public List<int>? RemoveUserIds { get; set; }
        public List<int>? RemoveLabelIds { get; set; }
    }
}
