using Core.DataAccess;
using Entities.Concretes;
using Entities.Dtos.Task;

namespace DataAccess.Abstracts
{
    public interface ITaskCommentRepository : IEntityRepository<TaskComment>
    {
        List<TaskCommentViewDto> GetAllByTaskId(int taskId);
    }
}
