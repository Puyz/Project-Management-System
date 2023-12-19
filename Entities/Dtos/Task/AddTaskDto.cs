using Core.Entities.Abstracts;

namespace Entities.Dtos.Task
{
    public class AddTaskDto : IDto
    { 
        public Concretes.Task Task { get; set; }
        public List<int>? AddUserIds { get; set; }
        public List<int>? AddLabelIds { get; set; }
    }
}
