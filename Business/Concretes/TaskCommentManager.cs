using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Task;

namespace Business.Concretes
{
    public class TaskCommentManager : ITaskCommentService
    {
        private readonly ITaskCommentRepository _taskCommentRepository;
        private readonly ITaskRepository _taskRepository;
        public TaskCommentManager(ITaskCommentRepository taskCommentRepository, ITaskRepository taskRepository)
        {
            _taskCommentRepository = taskCommentRepository;
            _taskRepository = taskRepository;
        }
        public IResult Add(TaskComment taskComment)
        {
            var task = _taskRepository.Get(task => task.Id.Equals(taskComment.TaskId));
            if (task == null) return new ErrorResult("Yorumun ekleneceği görev bulunamadı.");

            taskComment.CreatedDate = DateTime.Now;
            _taskCommentRepository.Add(taskComment);
            return new SuccessResult("Yorum eklendi.");
        }

        public IResult Delete(int taskCommentId)
        {
            var result = _taskCommentRepository.Get(comment => comment.Id.Equals(taskCommentId));
            if (result == null) return new ErrorResult("Silinecek yorum bulunamadı.");

            _taskCommentRepository.Delete(result);
            return new SuccessResult("Yorum silindi.");
        }

        public IResult DeleteAll(List<TaskCommentViewDto> taskComments)
        {
            if (taskComments == null || !taskComments.Any()) { return new ErrorResult("Silinecek yorumlar bulunamadı."); }
            foreach (var taskComment in taskComments)
            {
                Delete(taskComment.Id);
            }
            return new SuccessResult();
        }

        public IDataResult<List<TaskCommentViewDto>> GetAllByTaskId(int taskId)
        {
            var result = _taskCommentRepository.GetAllByTaskId(taskId);
            return new SuccessDataResult<List<TaskCommentViewDto>>(result);
        }
    }
}
