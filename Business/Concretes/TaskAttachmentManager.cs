using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;

namespace Business.Concretes
{
    public class TaskAttachmentManager : ITaskAttachmentService
    {
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
