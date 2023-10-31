using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class Board : IEntity
    {
        public int Id { get; set; }
        public int WorkspaceId { get; set; }
        public int CreatedUserId { get; set; }
        public string Name { get; set; }
        public bool PrivateToWorkspaceMember { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
