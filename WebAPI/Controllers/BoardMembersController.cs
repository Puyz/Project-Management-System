using Microsoft.AspNetCore.Mvc;
using Business.Abstracts;
using Entities.Concretes;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardMembersController : ControllerBase
    {
        private readonly IBoardMemberService _boardMemberService;

        public BoardMembersController(IBoardMemberService boardMemberService)
        {
            _boardMemberService = boardMemberService;
        }

        [HttpPost("add")]
        public IActionResult Add(List<BoardMember> boardMembers)
        {
            var result = _boardMemberService.Add(boardMembers);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int boardMemberId)
        {
            var result = _boardMemberService.Delete(boardMemberId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getallbyboardid")]
        public IActionResult GetAllByBoardId(int boardId)
        {
            var result = _boardMemberService.GetAllByBoardId(boardId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getallbyboardidwithusers")]
        public IActionResult GetAllByBoardIdWithUsers(int boardId)
        {
            var result = _boardMemberService.GetAllByBoardIdWithUsers(boardId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
    }
}
