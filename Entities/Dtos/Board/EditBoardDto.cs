using Core.Entities.Abstracts;

namespace Entities.Dtos.Board
{
    public class EditBoardDto : IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool PrivateToWorkspaceMember { get; set; }
        public DateTime EndDate { get; set; }
    }
}
