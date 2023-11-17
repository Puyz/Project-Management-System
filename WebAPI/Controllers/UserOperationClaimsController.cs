using Business.Abstracts;
using Core.Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOperationClaimsController : ControllerBase
    {
        private readonly IUserOperationClaimService _userOperationClaimService;

        public UserOperationClaimsController(IUserOperationClaimService userOperationClaimService)
        {
            _userOperationClaimService = userOperationClaimService;
        }

        [HttpPost("add")]
        public IActionResult Add(UserOperationClaim userOperationClaim)
        {
            var result = _userOperationClaimService.Add(userOperationClaim);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(UserOperationClaim userOperationClaim)
        {
            var result = _userOperationClaimService.Update(userOperationClaim);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int userOperationClaimId)
        {
            var result = _userOperationClaimService.Delete(userOperationClaimId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _userOperationClaimService.GetById(id);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
        [HttpGet("getList")]
        public IActionResult GetList(int userId, int workspaceId)
        {
            var result = _userOperationClaimService.GetAll(userId, workspaceId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
        [HttpGet("getListDto")]
        public IActionResult GetListDto(int userId, int workspaceId)
        {
            var result = _userOperationClaimService.GetListDto(userId, workspaceId);
            return (result.Success) ? Ok(result) : BadRequest(result);
        }
    }
}
