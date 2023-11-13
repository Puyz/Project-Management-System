using Business.Abstracts;
using Microsoft.AspNetCore.Http;
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
            return (result.Success) ? Ok(result) : BadRequest();
        }
    }
}
