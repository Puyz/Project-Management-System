using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;

namespace Business.Abstracts
{
    public interface ITaskAttachmentService
    {
        Task<IResult> Add(List<IFormFile> taskAttachments, int taskId);
        IResult Delete(int taskAttachmentId);
        IResult DeleteAll(List<int> taskAttachmentIds);
        IDataResult<List<TaskAttachment>> GetAllByTaskId(int taskId);
        IDataResult<List<int>> GetAllIdByTaskId(int taskId);
    }
}
