namespace Entities.Dtos.Board
{
    public class BoardViewDto
    {
        public int Id { get; set; }
        public UserViewDto? CreatedUser { get; set; }
        public List<UserViewDto>? BoardMembers { get; set; }
        public string? Name { get; set; }
        public bool PrivateToWorkspaceMember { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
