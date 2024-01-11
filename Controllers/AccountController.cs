using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopBackEnd.DTOs;
using ShopBackEnd.Entities;

namespace ShopBackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly TokenService _tokenService;

        public AccountController(UserManager<User> userManager, TokenService tokenService) 
        {
            _userManager = userManager;
            _tokenService = tokenService;
        }
        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByNameAsync(loginDto.Username);
            if (user == null || !await _userManager.CheckPasswordAsync(user, loginDto.Password)) 
            return Unauthorized();
            return new UserDto{
                Email = user.Email,
                Token = await _tokenService.GenerateToken(user)
            };
        }
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(RegisterDto registerDto)
        {
            var user = new User { Id = Guid.NewGuid().ToString(), UserName = registerDto.Username, Email = registerDto.Email };
            var result = await _userManager.CreateAsync(user,registerDto.Password);
            if (!result.Succeeded)
            {
               foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return ValidationProblem();
            }
            await _userManager.AddToRolesAsync(user, new List<string> { "Member" });
            return StatusCode(201);
        }
        [Authorize]
        [HttpGet("currentUser")]
        public async Task<ActionResult<UserDto>> GetCurrentUser(){
           var user = await _userManager.FindByNameAsync(User.Identity.Name);
           return new UserDto{
            Email = user.Email,
            Token = await _tokenService.GenerateToken(user)
           };
        }
    }
}
