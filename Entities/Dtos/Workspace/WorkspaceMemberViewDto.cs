namespace Entities.Dtos.Workspace
{
    public class WorkspaceMemberViewDto
    {
        public int Id { get; set; }
        public int WorkspaceId { get; set; }
        public UserViewDto User { get; set; }
    }
}
