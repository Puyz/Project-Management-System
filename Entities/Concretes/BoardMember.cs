using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class BoardMember : IEntity
    {
        public int Id { get; set; }
        public int BoardId { get; set; }
        public int UserId { get; set; }
    }
}
