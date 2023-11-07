using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class WorkspaceType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
