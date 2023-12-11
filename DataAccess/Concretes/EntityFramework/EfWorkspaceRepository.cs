using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfWorkspaceRepository : EfEntityRepositoryBase<Workspace, PMSContext>, IWorkspaceRepository
    {
        public List<Workspace> GetAllByUserId(int userId)
        {
            using (var context = new PMSContext())
            {
                var result = (from workspace in context.Workspaces
                              join workspaceMember in context.WorkspaceMembers on workspace.Id equals workspaceMember.WorkspaceId
                              where workspace.CreatedUserId == userId || workspaceMember.UserId == userId
                              select new Workspace
                              {
                                  Id = workspace.Id,
                                  WorkspaceTypeId = workspace.WorkspaceTypeId,
                                  CreatedUserId = workspace.CreatedUserId,
                                  Name = workspace.Name,
                                  Description = workspace.Description
                              }).ToList();
                return result;
            }




        }
    }
}
