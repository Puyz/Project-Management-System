using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class TaskLabelManager : ITaskLabelService
    {
        private readonly ITaskLabelRepository _taskLabelRepository;
        private readonly ITaskRepository _taskRepository;
        public TaskLabelManager(ITaskLabelRepository taskLabelRepository, ITaskRepository taskRepository)
        {
            _taskLabelRepository = taskLabelRepository;
            _taskRepository = taskRepository;
        }

        public IResult Add(List<int> labelIds, int taskId)
        {
            var task = _taskRepository.Get(t => t.Id.Equals(taskId));
            if (task == null) return new ErrorResult("Etiketin ekleneceği görev bulunamadı.");

            foreach (var labelId in labelIds)
            {
                var result = _taskLabelRepository.Get(label => label.Id.Equals(labelId) && label.TaskId.Equals(taskId));
                if (result == null)
                {
                    TaskLabel taskLabel = new()

                    {
                        LabelId = labelId,
                        TaskId = taskId
                    };
                    _taskLabelRepository.Add(taskLabel);
                }
            }
            return new SuccessResult("Görev etiketleri eklendi.");
        }

        public IResult DeleteAllByLabelIdsAndTaskId(List<int> labelIds, int taskId)
        {
            if (labelIds == null || !labelIds.Any()) return new ErrorResult("Silinecek görev etiketleri bulunamadı.");
            foreach (var labelId in labelIds)
            {
                DeleteByLabelIdAndTaskId(labelId, taskId);
            }
            return new SuccessResult();
        }

        public IResult DeleteAllByTaskLabelIds(List<int> taskLabelIds)
        {
            if (taskLabelIds == null || !taskLabelIds.Any()) return new ErrorResult("Silinecek görev etiketleri bulunamadı.");
            foreach (var taskLabelId in taskLabelIds)
            {
                DeleteByTaskLabelId(taskLabelId);
            }
            return new SuccessResult();
        }

        public IResult DeleteByLabelIdAndTaskId(int labelId, int taskId)
        {
            var result = _taskLabelRepository.Get(taskLabel => taskLabel.LabelId.Equals(labelId) && taskLabel.TaskId.Equals(taskId));
            if (result == null) return new ErrorResult("Silinecek görev etiketi bulunamadı.");

            _taskLabelRepository.Delete(result);

            return new SuccessResult("Görev etiketi silindi.");
        }

        public IResult DeleteByTaskLabelId(int taskLabelId)
        {
            var result = _taskLabelRepository.Get(taskLabel => taskLabel.Id.Equals(taskLabelId));
            if (result == null) return new ErrorResult("Silinecek görev etiketi bulunamadı.");

            _taskLabelRepository.Delete(result);

            return new SuccessResult("Görev etiketi silindi.");
        }

        public IDataResult<List<TaskLabel>> GetAllByTaskId(int taskId)
        {
            var result = _taskLabelRepository.GetAll(taskLabel => taskLabel.TaskId.Equals(taskId));
            return new SuccessDataResult<List<TaskLabel>>(result);
        }

        public IDataResult<List<int>> GetAllIdByTaskId(int taskId)
        {
            var result = _taskLabelRepository.GetAll(taskLabel => taskLabel.TaskId.Equals(taskId)).Select(taskLabel => taskLabel.Id).ToList();
            return new SuccessDataResult<List<int>>(result);
        }
    }
}
