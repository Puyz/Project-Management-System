using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Context;
using Entities.Concretes;
using Entities.Dtos.Task;
using Entities.Dtos.TaskList;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfTaskListRepository : EfEntityRepositoryBase<TaskList, PMSContext>, ITaskListRepository
    {
        public List<TaskListViewDto> GetAllWithTasks(int boardId)
        {
            using (var context = new PMSContext())
            {
                var result = (from taskList in context.TaskLists
                              where taskList.BoardId == boardId
                              select new TaskListViewDto
                              {
                                  Id = taskList.Id,
                                  BoardId = boardId,
                                  Name = taskList.Name!,
                                  OrderNo = taskList.OrderNo,
                                  Tasks = context.Tasks.Where(task => task.TaskListId == taskList.Id)
                                  .Select(task => new TaskViewForTaskListDto
                                  {

                                      Id = task.Id,
                                      TaskListId = taskList.Id,
                                      Name = task.Name!,
                                      AttachmentCount = context.TaskAttachments.Count(ta => ta.TaskId == task.Id),
                                      CommentCount = context.TaskComments.Count(tc => tc.TaskId == task.Id),
                                      OrderNo = task.OrderNo,
                                      DueDate = task.DueDate,
                                      taskLabels = context.TaskLabels
                                                .Where(taskLabel => taskLabel.TaskId == task.Id)
                                                .Join(context.Labels, taskLabel => taskLabel.LabelId, label => label.Id,
                                                    (taskLabel, label) => new TaskLabelDto
                                                    {
                                                        Id = taskLabel.Id,
                                                        LabelId = label.Id,
                                                        Name = label.Name!,
                                                        Color = label.Color!,
                                                    }).ToList(),
                                      taskMembers = context.TaskMembers
                                                .Where(taskMember => taskMember.TaskId == task.Id)
                                                .Join(context.Users, taskMember => taskMember.UserId, user => user.Id,
                                                    (taskMember, user) => new TaskMemberDto
                                                    {
                                                        Id = taskMember.Id,
                                                        UserId = user.Id,
                                                        Name = user.Name!,
                                                        Email = user.Email!,
                                                        Image = user.Image
                                                    })
                                                .ToList()

                                  }).ToList()
                              }).OrderBy(taskList => taskList.OrderNo).ToList();

                return result;
            }
        }
    }
}
