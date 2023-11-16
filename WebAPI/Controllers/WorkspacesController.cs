using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkspacesController : ControllerBase
    {
        private readonly IWorkspaceService _workspaceService;

        public WorkspacesController(IWorkspaceService workspaceService)
        {
            _workspaceService = workspaceService;
        }

        [HttpGet("getallbyuserid")]
        public IActionResult GetAllByUserId(int userId)
        {
            var result = _workspaceService.GetAllByUserId(userId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpGet("add")]
        public IActionResult Add(Workspace workspace)
        {
            var result = _workspaceService.Add(workspace);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpGet("delete")]
        public IActionResult Delete(int workspaceId)
        {
            var result = _workspaceService.Delete(workspaceId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpGet("update")]
        public IActionResult Update(Workspace workspace)
        {
            var result = _workspaceService.Update(workspace);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
    }
}
