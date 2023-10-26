using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class TaskCommentManager : ITaskCommentService
    {
        public IResult Add(TaskComment taskComment)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int taskCommentId)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteAll(List<TaskComment> taskComments)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TaskComment>> GetAllByTaskId(int taskId)
        {
            throw new NotImplementedException();
        }
    }
}
