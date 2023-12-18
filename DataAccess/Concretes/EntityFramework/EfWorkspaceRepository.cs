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
                var workspaces = (from workspace in context.Workspaces
                                  where workspace.CreatedUserId == userId
                                  select new Workspace
                                  {
                                      Id = workspace.Id,
                                      WorkspaceTypeId = workspace.WorkspaceTypeId,
                                      CreatedUserId = workspace.CreatedUserId,
                                      Name = workspace.Name,
                                      Description = workspace.Description
                                  }).ToList();

                var memberWorkspaces = (from workspaceMember in context.WorkspaceMembers
                                        join workspace in context.Workspaces on workspaceMember.WorkspaceId equals workspace.Id
                                        where workspaceMember.UserId == userId
                                        select new Workspace
                                        {
                                            Id = workspace.Id,
                                            WorkspaceTypeId = workspace.WorkspaceTypeId,
                                            CreatedUserId = workspace.CreatedUserId,
                                            Name = workspace.Name,
                                            Description = workspace.Description
                                        }).ToList();

                var result = workspaces.Concat(memberWorkspaces).ToList();


                return result;
            }




        }
    }
}
