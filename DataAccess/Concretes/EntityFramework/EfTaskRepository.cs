using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Context;
using Entities.Dtos.Task;
using Task = Entities.Concretes.Task;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfTaskRepository : EfEntityRepositoryBase<Task, PMSContext>, ITaskRepository
    {
        public TaskViewDto GetTaskByTaskId(int taskId)
        {
            using (var context = new PMSContext())
            {
                var result = (from task in context.Tasks
                              where task.Id == taskId
                              select new TaskViewDto
                              {
                                  Task = task,
                                  TaskLabels = context.TaskLabels
                                                .Where(taskLabel => taskLabel.TaskId == taskId)
                                                .Join(context.Labels, taskLabel => taskLabel.LabelId, label => label.Id,
                                                    (taskLabel, label) => new TaskLabelDto
                                                    {
                                                        Id = taskLabel.Id,
                                                        LabelId = label.Id,
                                                        Name = label.Name,
                                                        Color = label.Color,
                                                    }).ToList(),
                                  TaskMembers = context.TaskMembers
                                                .Where(taskMember => taskMember.TaskId == taskId)
                                                .Join(context.Users, taskMember => taskMember.UserId, user => user.Id,
                                                    (taskMember, user) => new TaskMemberDto
                                                    {
                                                        Id = taskMember.Id,
                                                        UserId = user.Id,
                                                        Name = user.Name,
                                                        Email = user.Email,
                                                        Image = user.Image
                                                    })
                                                .ToList(),
                              }).SingleOrDefault();
                return result;
            }
        }
    }
}
