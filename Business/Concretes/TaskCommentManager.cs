using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Task;

namespace Business.Concretes
{
    public class TaskCommentManager : ITaskCommentService
    {
        private readonly ITaskCommentRepository _taskCommentRepository;
        public TaskCommentManager(ITaskCommentRepository taskCommentRepository) {
            _taskCommentRepository = taskCommentRepository;
        }
        public IResult Add(TaskComment taskComment)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int taskCommentId)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteAll(List<TaskCommentViewDto> taskComments)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TaskCommentViewDto>> GetAllByTaskId(int taskId)
        {
            throw new NotImplementedException();
        }
    }
}
