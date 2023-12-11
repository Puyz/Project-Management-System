using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class Workspace : IEntity
    {
        public int Id { get; set; }
        public int WorkspaceTypeId { get; set; }
        public int CreatedUserId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

    }
}
