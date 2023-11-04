using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Context;
using Entities.Concretes;
using Entities.Dtos;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfTaskMemberRepository : EfEntityRepositoryBase<TaskMember, PMSContext>, ITaskMemberRepository
    {
        public List<UserViewDto> GetTaskMembersAsUserByBoardId(int boardId)
        {
            using var context = new PMSContext();
            var result = (from board in context.Boards
                          where board.Id == boardId
                          join taskList in context.TaskLists on board.Id equals taskList.BoardId
                          join task in context.Tasks on taskList.Id equals task.TaskListId
                          join taskMember in context.TaskMembers on task.Id equals taskMember.TaskId
                          join user in context.Users on taskMember.UserId equals user.Id
                          select new { User = user })
                          .Distinct()
                          .ToList();

            var userDtoList = result.Select(r => new UserViewDto
            {
                Id = r.User.Id,
                Name = r.User.Name,
                Email = r.User.Email,
                Image = r.User.Image,
                CreatedDate = r.User.CreatedDate
            }).ToList();

            return userDtoList;
        }
    }
}
