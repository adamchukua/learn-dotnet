using Lab6.Models;
using Lab6.Services.UserData;
using Microsoft.AspNetCore.Mvc;

namespace Lab6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserData _userData;

        public UserController(IUserData userData)
        {
            _userData = userData;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDto userDto)
        {
            try
            {
                var user = await _userData.Register(userDto);
                return Ok(user);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserDto userDto)
        {
            try
            {
                var user = await _userData.Login(userDto);
                return Ok(user);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
