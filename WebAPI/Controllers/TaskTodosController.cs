using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskTodosController : ControllerBase
    {
        private readonly ITaskTodoService _taskTodoService;

        public TaskTodosController(ITaskTodoService taskTodoService)
        {
            _taskTodoService = taskTodoService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] TaskTodo taskTodo)
        {
            var result = _taskTodoService.Add(taskTodo);

            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _taskTodoService.Delete(id);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] TaskTodo taskTodo)
        {
            var result = _taskTodoService.Update(taskTodo);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPut("change")]
        public IActionResult Change(int id, Boolean state)
        {
            var result = _taskTodoService.Change(id, state);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
    }
}

