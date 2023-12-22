using Microsoft.AspNetCore.Mvc;
using Entities.Concretes;
using Business.Abstracts;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabelsController : ControllerBase
    {
        private readonly ILabelService _labelService;

        public LabelsController(ILabelService labelService)
        {
            _labelService = labelService;
        }

        [HttpPost("add")]
        public IActionResult Add(Label label)
        {
            var result = _labelService.Add(label);
            return (result.Success) ? Ok(result) : BadRequest();
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int labelId)
        {
            var result = _labelService.Delete(labelId);
            return (result.Success) ? Ok(result) : BadRequest();
        }

        [HttpPut("update")]
        public IActionResult Update(Label label)
        {
            var result = _labelService.Update(label);
            return (result.Success) ? Ok(result) : BadRequest();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _labelService.GetAll();
            return (result.Success) ? Ok(result) : BadRequest();
        }

    }
}
