using Chat.BussinesLogic.Abstraction;
using Chat.BussinesLogic.DTOs.Account;
using Chat.BussinesLogic.DTOs.User;
using Chat.DataAccess.Entity.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Api.Controllers
{
    [ApiController]
    [Route("api/user")]
    [Authorize]
    public class UserController(IUserService userService) : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync(CreateUserRequest request, CancellationToken cancellationToken)
        {
            await userService.CreateAsync(request, cancellationToken);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet("getAll")]
        public async Task<List<UserResponse>> GetAll(CancellationToken cancellationToken)
        {            
            return await userService.GetAllAsync(cancellationToken);
        }

        [HttpGet("test-exception")]
        public IActionResult TestException()
        {
            throw new Exception("TEST EXCEPTION FROM CONTROLLER");
        }
    }
}
