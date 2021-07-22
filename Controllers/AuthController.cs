using System.Threading.Tasks;
using dot_net_api_rpg.Data;
using dot_net_api_rpg.Dtos.User;
using dot_net_api_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dot_net_api_rpg.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller

    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;

        }


        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDto request)
        {
            ServiceResponse<int> response = await _authRepo.Register(
                new User { UserName = request.UserName }, request.Password
            );
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDto request)
        {
            ServiceResponse<string> response = await _authRepo.Login(
                request.UserName, request.Password
            );
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}