using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class TaskAttachment : IEntity
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string AttachmentPath { get; set; }
    }
}
