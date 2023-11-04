using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Context;
using Entities.Concretes;
using Entities.Dtos;
using Entities.Dtos.Task;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfTaskCommentRepository : EfEntityRepositoryBase<TaskComment, PMSContext>, ITaskCommentRepository
    {
        public List<TaskCommentViewDto> GetAllByTaskId(int taskId)
        {
            using var context = new PMSContext();
            var result = (from taskComment in context.TaskComments
                          where taskComment.TaskId == taskId
                          join user in context.Users on taskComment.UserId equals user.Id
                          orderby taskComment.CreatedDate descending
                          select new TaskCommentViewDto
                          {
                              Id = taskComment.Id,
                              Content = taskComment.Content!,
                              CreatedDate = taskComment.CreatedDate,
                              User = new UserViewDto
                              {
                                  Id = user.Id,
                                  Name = user.Name,
                                  Email = user.Email,
                                  CreatedDate = user.CreatedDate,
                                  Image = user.Image
                              }

                          }).ToList();
            return result;

        }
    }
}
