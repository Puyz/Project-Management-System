using Core.Entities.Abstracts;

namespace Entities.Dtos
{
    public class UserViewDto : IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Image { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
