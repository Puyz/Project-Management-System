using Core.DataAccess.EntityFramework;
using Core.Entities.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Context;
using Entities.Concretes;
using Entities.Dtos;
using Entities.Dtos.Workspace;

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

        public WorkspaceViewDto GetById(int workspaceId)
        {
            using (var context = new PMSContext())
            {
                var result = (from workspace in context.Workspaces
                              where workspace.Id == workspaceId
                              join user in context.Users on workspace.CreatedUserId equals user.Id
                              select new WorkspaceViewDto
                              {
                                  Id = workspace.Id,
                                  WorkspaceTypeId = workspace.WorkspaceTypeId,
                                  CreatedUser = new UserViewDto
                                  {
                                      Id = user.Id,
                                      Email = user.Email,
                                      Image = user.Image,
                                      Name = user.Name,
                                  },
                                  Name = workspace.Name,
                                  Description = workspace.Description
                              }).SingleOrDefault();
                return result;
            }
        }
    }
}
