using Business.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskMembersController : ControllerBase
    {
        private readonly ITaskMemberService _taskMemberService;

        public TaskMembersController(ITaskMemberService taskMemberService)
        {
            _taskMemberService = taskMemberService;
        }

        [HttpGet("getallbyboardid")]
        public IActionResult GetAllAsUserByBoardId(int boardId)
        {
            var result = _taskMemberService.GetTaskMembersAsUserByBoardId(boardId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
    }
}
