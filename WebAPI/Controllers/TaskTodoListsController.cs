using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskTodoListsController : ControllerBase
    {

        private readonly ITaskTodoListService _taskTodoListService;

        public TaskTodoListsController(ITaskTodoListService taskTodoListServie)
        {
            _taskTodoListService = taskTodoListServie;
        }

        [HttpGet("getallwithtodo")]
        public IActionResult GetAllWithTodo(int taskId)
        {
            var result = _taskTodoListService.GetAllWithTodoByTaskId(taskId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] TaskTodoList taskTodoList)
        {
            var result = _taskTodoListService.Add(taskTodoList);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _taskTodoListService.Delete(id);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] TaskTodoList taskTodoList)
        {
            var result = _taskTodoListService.Update(taskTodoList);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
    }
}

