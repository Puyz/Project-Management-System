using Core.DataAccess;
using Entities.Concretes;
using Entities.Dtos.TaskList;

namespace DataAccess.Abstracts
{
    public interface ITaskListRepository : IEntityRepository<TaskList>
    {
        List<TaskListViewDto> GetAllWithTasks(int boardId);
    }
}
