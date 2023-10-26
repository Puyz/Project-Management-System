using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;

namespace Business.Concretes
{
    public class TaskAttachmentManager : ITaskAttachmentService
    {
        private readonly ITaskAttachmentRepository _taskAttachmentRepository;

        public TaskAttachmentManager(ITaskAttachmentRepository taskAttachmentRepository)
        {
            _taskAttachmentRepository = taskAttachmentRepository;
        }

        public Task<IResult> Add(List<IFormFile> taskAttachments, int taskId)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int taskAttachmentId)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteAll(List<int> taskAttachmentIds)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TaskAttachment>> GetAllByTaskId(int taskId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<int>> GetAllIdByTaskId(int taskId)
        {
            throw new NotImplementedException();
        }
    }
}
