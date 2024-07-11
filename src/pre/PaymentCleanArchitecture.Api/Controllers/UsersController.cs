using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentCleanArchitecture.Application.Features.User.DTOs;

namespace PaymentCleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            return Ok();
        }
        [HttpPost]
        [Route("/register")]
        public async Task<IActionResult> Register([FromBody] CreateUserDto userDto)
        {
            return Ok();
        }
    }
}
