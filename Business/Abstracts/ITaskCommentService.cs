using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Task;

namespace Business.Abstracts
{
    public interface ITaskCommentService
    {
        IResult Add(TaskComment taskComment);

        IResult Delete(int taskCommentId);

        IResult DeleteAll(List<TaskCommentViewDto> taskComments);

        IDataResult<List<TaskCommentViewDto>> GetAllByTaskId(int taskId);
    }
}
