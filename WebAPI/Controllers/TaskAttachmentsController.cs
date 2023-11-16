using Business.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskAttachmentsController : ControllerBase
    {
        private readonly ITaskAttachmentService _taskAttachmentService;

        public TaskAttachmentsController(ITaskAttachmentService taskAttachmentService)
        {
            _taskAttachmentService = taskAttachmentService;
        }

        [HttpGet("getallbytaskid")]
        public IActionResult GetAllByTaskId(int taskId)
        {
            var result = _taskAttachmentService.GetAllByTaskId(taskId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPost("add")]
        [RequestSizeLimit(10 * 1024 * 1024)] // 10MB
        public async Task<IActionResult> Add([FromForm] List<IFormFile> taskAttachments, [FromForm] int taskId)
        {
            var result = await _taskAttachmentService.Add(taskAttachments, taskId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int taskAttachmentId)
        {
            var result = _taskAttachmentService.Delete(taskAttachmentId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

    }
}
