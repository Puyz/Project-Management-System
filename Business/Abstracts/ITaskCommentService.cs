using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ITaskCommentService
    {
        IResult Add(TaskComment taskComment);

        IResult Delete(int taskCommentId);

        IResult DeleteAll(List<TaskComment> taskComments); // dto

        IDataResult<List<TaskComment>> GetAllByTaskId(int taskId); // dto gelecek
    }
}
