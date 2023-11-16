using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkspaceTypesController : ControllerBase
    {
        private readonly IWorkspaceTypeService _workspaceTypeService;

        public WorkspaceTypesController(IWorkspaceTypeService workspaceTypeService)
        {
            _workspaceTypeService = workspaceTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _workspaceTypeService.GetAll();
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int workspaceTypeId)
        {
            var result = _workspaceTypeService.GetById(workspaceTypeId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(WorkspaceType workspaceType)
        {
            var result = _workspaceTypeService.Add(workspaceType);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int workspaceTypeId)
        {
            var result = _workspaceTypeService.Delete(workspaceTypeId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(WorkspaceType workspaceType)
        {
            var result = _workspaceTypeService.Update(workspaceType);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
    }
}
