using Core.Entities.Abstracts;

namespace Core.Entities.Concretes
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public byte[]? Password { get; set; }
        public string? Image { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
