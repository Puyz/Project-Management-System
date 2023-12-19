using System;
using Core.Entities.Abstracts;

namespace Entities.Dtos.Workspace
{
	public class WorkspaceViewDto : IDto
    {
        public int Id { get; set; }
        public int WorkspaceTypeId { get; set; }
        public UserViewDto CreatedUser { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}

