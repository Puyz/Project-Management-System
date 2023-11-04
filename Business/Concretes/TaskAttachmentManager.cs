using Business.Abstracts;
using Business.File;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;

namespace Business.Concretes
{
    public class TaskAttachmentManager : ITaskAttachmentService
    {
        private readonly ITaskAttachmentRepository _taskAttachmentRepository;
        private readonly IFileService _fileService;

        public TaskAttachmentManager(ITaskAttachmentRepository taskAttachmentRepository, IFileService fileService)
        {
            _taskAttachmentRepository = taskAttachmentRepository;
            _fileService = fileService;
        }

        public async Task<IResult> Add(List<IFormFile> taskAttachments, int taskId)
        {
            foreach (var taskAttachment in taskAttachments)
            {
                if (taskAttachment.Length > 0)
                {
                    var result = await _fileService.Save(taskAttachment, FileType.TASK_ATTACHMENT);
                    if (!result.Success) continue;

                    TaskAttachment newTaskAttachment = new()
                    {
                        TaskId = taskId,
                        Name = result.Data.Name,
                        AttachmentPath = result.Data.FilePath
                    };
                    _taskAttachmentRepository.Add(newTaskAttachment);
                }
            }
            return new SuccessResult("Başarılı.");
        }

        public IResult Delete(int taskAttachmentId)
        {
            var result = _taskAttachmentRepository.Get(p => p.Id.Equals(taskAttachmentId));
            if (result == null) return new ErrorResult("Silinecek görev eki bulunamadı.");

            _taskAttachmentRepository.Delete(result);
            _fileService.Delete(result.AttachmentPath, FileType.TASK_ATTACHMENT);

            return new SuccessResult("Görev eki silindi.");
        }

        public IResult DeleteAll(List<int> taskAttachmentIds)
        {
            if (taskAttachmentIds == null || !taskAttachmentIds.Any()) return new ErrorResult("Silinecek görev ekleri bulunamadı.");
            foreach (var taskAttachmentId in taskAttachmentIds)
            {
                Delete(taskAttachmentId);
            }
            return new SuccessResult();
        }

        public IDataResult<List<TaskAttachment>> GetAllByTaskId(int taskId)
        {
            var result = _taskAttachmentRepository.GetAll(p => p.TaskId.Equals(taskId));
            return new SuccessDataResult<List<TaskAttachment>>(result);
        }

        public IDataResult<List<int>> GetAllIdByTaskId(int taskId)
        {
            var result = _taskAttachmentRepository.GetAll(p => p.TaskId.Equals(taskId)).Select(p => p.Id).ToList();
            return new SuccessDataResult<List<int>>(result);
        }
    }
}
