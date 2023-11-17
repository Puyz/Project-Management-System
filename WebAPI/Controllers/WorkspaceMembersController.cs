using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkspaceMembersController : ControllerBase
    {
        private readonly IWorkspaceMemberService _workspaceMemberService;

        public WorkspaceMembersController(IWorkspaceMemberService workspaceMemberService)
        {
            _workspaceMemberService = workspaceMemberService;
        }

        [HttpGet("getallbyworkspaceid")]
        public IActionResult GetAllByWorkspaceId(int workspaceId)
        {
            var result = _workspaceMemberService.GetAllByWorkspaceId(workspaceId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getallbyworkspaceidwithusers")]
        public IActionResult GetAllByWorkspaceIdWithUsers(int workspaceId)
        {
            var result = _workspaceMemberService.GetAllByWorkspaceIdWithUsers(workspaceId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(List<WorkspaceMember> workspaceMembers)
        {
            var result = _workspaceMemberService.Add(workspaceMembers);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int workspaceMemberId)
        {
            var result = _workspaceMemberService.Delete(workspaceMemberId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
    }
}
