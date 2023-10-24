using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class WorkspaceMember : IEntity
    {
        public int Id { get; set; }
        public int WorkspaceId { get; set; }
        public int UserId { get; set; }
    }
}
