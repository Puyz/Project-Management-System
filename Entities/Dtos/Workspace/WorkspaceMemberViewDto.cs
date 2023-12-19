using Core.Entities.Abstracts;

namespace Entities.Dtos.Workspace
{
    public class WorkspaceMemberViewDto : IDto
    {
        public int Id { get; set; }
        public int WorkspaceId { get; set; }
        public UserViewDto User { get; set; }
    }
}
