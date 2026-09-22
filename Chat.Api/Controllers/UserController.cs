using Chat.BussinesLogic.Abstraction;
using Chat.BussinesLogic.DTOs.Request.User;
using Chat.DataAccess.Entity.User;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Api.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController(IUserService userService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateUserRequest request, CancellationToken cancellationToken)
        {
            await userService.CreateAsync(request, cancellationToken);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet]
        public async Task<List<UserResponse>> GetAll(CancellationToken cancellationToken)
        {            
            return await userService.GetAllAsync(cancellationToken);
        }

    }
}
