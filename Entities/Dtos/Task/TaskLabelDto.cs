using Core.Entities.Abstracts;

namespace Entities.Dtos.Task
{
    public class TaskLabelDto : IDto
    {
        public int Id { get; set; }
        public int LabelId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
