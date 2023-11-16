using Business.Abstracts;
using Entities.Dtos.Task;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int taskId)
        {
            var result = _taskService.GetById(taskId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] AddTaskDto addTaskDto)
        {
            var result = _taskService.Add(addTaskDto);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int taskId)
        {
            var result = _taskService.Delete(taskId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] EditTaskDto editTaskDto)
        {
            var result = _taskService.Update(editTaskDto);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPut("updateorder")]
        public IActionResult UpdateOrder([FromBody] TaskOrderEditDto taskOrderEditDto)
        {
            var result = _taskService.UpdateOrder(taskOrderEditDto);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
    }
}
