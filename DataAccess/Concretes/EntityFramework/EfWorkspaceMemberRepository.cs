using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Context;
using Entities.Concretes;
using Entities.Dtos.Workspace;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfWorkspaceMemberRepository : EfEntityRepositoryBase<WorkspaceMember, PMSContext>, IWorkspaceMemberRepository
    {
        public List<WorkspaceMemberViewDto> GetAllByWorkspaceIdWithUsers(int workspaceId)
        {
            using (var context = new PMSContext())
            {
                var result = (from workspaceMember in context.WorkspaceMembers
                              where workspaceMember.WorkspaceId == workspaceId
                              join user in context.Users on workspaceMember.UserId equals user.Id
                              select new WorkspaceMemberViewDto
                              {
                                  Id = workspaceMember.Id,
                                  WorkspaceId = workspaceId,
                                  User = new Entities.Dtos.UserViewDto
                                  {
                                      Id = user.Id,
                                      Name = user.Name,
                                      Email = user.Email,
                                      Image = user.Image,
                                      CreatedDate = user.CreatedDate
                                  }
                              }).ToList();
                return result;
            }
        }
    }
}
