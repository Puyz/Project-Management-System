using Core.DataAccess;
using Entities.Concretes;
using Entities.Dtos;

namespace DataAccess.Abstracts
{
    public interface ITaskMemberRepository : IEntityRepository<TaskMember>
    {
        List<UserViewDto> GetTaskMembersAsUserByBoardId(int boardId);
    }
}
