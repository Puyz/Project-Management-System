using Business.Abstracts;
using Entities.Concretes;
using Entities.Dtos.TaskList;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskListsController : ControllerBase
    {
        private readonly ITaskListService _taskListService;

        public TaskListsController(ITaskListService taskListService)
        {
            _taskListService = taskListService;
        }

        [HttpGet("getallwithtasks")]
        public IActionResult GetAllWithTasks(int boardId)
        {
            var result = _taskListService.GetAllWithTasks(boardId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] TaskList taskList)
        {
            var result = _taskListService.Add(taskList);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int taskListId)
        {
            var result = _taskListService.Delete(taskListId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] TaskList taskList)
        {
            var result = _taskListService.Update(taskList);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPut("updateorder")]
        public IActionResult UpdateOrder([FromBody] TaskListUpdateOrderDto taskListUpdateOrderdto)
        {
            var result = _taskListService.UpdateOrder(taskListUpdateOrderdto);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

    }
}
