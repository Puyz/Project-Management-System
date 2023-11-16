using Business.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Board;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardsController : ControllerBase
    {
        private readonly IBoardService _boardService;

        public BoardsController(IBoardService boardService)
        {
            _boardService = boardService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll(int workspaceId, int userId)
        {
            var result = _boardService.GetAll(workspaceId, userId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getallbyworkspaceid")]
        public IActionResult GetAllByWorkspaceId(int workspaceId)
        {
            var result = _boardService.GetAllByWorkspaceId(workspaceId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int boardId)
        {
            var result = _boardService.Get(boardId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Board board)
        {
            var result = _boardService.Add(board);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int boardId)
        {
            var result = _boardService.Delete(boardId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(EditBoardDto board)
        {
            var result = _boardService.Update(board);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        
    }
}
