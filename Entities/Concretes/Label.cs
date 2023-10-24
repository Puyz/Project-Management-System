using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class Label : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
    }
}
