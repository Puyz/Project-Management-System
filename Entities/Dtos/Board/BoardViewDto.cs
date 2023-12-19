using Core.Entities.Abstracts;

namespace Entities.Dtos.Board
{
    public class BoardViewDto : IDto
    {
        public int Id { get; set; }
        public int WorkspaceId { get; set; }
        public UserViewDto? CreatedUser { get; set; }
        public List<BoardMemberViewDto>? BoardMembers { get; set; }
        public string Name { get; set; }
        public bool PrivateToWorkspaceMember { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
