using DotnetBlogApi.Dto;
using DotnetBlogApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace DotnetBlogApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController: ControllerBase
    {
        private readonly AuthService _authservice;

        public AuthController(AuthService authService)
        {
            _authservice = authService;
        }

        [HttpPost]
        public IActionResult loginUser([FromBody] UserLoginRequest userLoginRequest)
        {
            return Ok(_authservice.loginUser(userLoginRequest));
        }
    }
}
