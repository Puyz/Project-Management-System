namespace Entities.Dtos.Task
{
    public class AddTaskDto
    { 
        public Concretes.Task Task { get; set; }
        public List<int>? AddUserIds { get; set; }
        public List<int>? AddLabelIds { get; set; }
    }
}
