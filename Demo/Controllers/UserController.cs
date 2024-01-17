using Demo.Core.ViewModels;
using Demo.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Add a new user
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateUser(UserViewModel model)
        {
            if (!ModelState.IsValid) { return BadRequest(); }
            var isUserCreated = await _userService.CreateUser(model);
            return isUserCreated ? HandleResponse(isUserCreated) : BadRequest();
        }
    }
}
