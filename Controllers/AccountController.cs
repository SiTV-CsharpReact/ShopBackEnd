using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopBackEnd.DTOs;
using ShopBackEnd.Entities;

namespace ShopBackEnd.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        public AccountController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        [HttpPost("login")]
        public async Task<ActionResult<User>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByNameAsync(loginDto.Username);
            if (user == null || !await _userManager.CheckPasswordAsync(user, loginDto.Password)) 
            return Unauthorized();
            return user;
        }
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(RegisterDto registerDto)
        {
            var user = new User { UserName = registerDto.Username, Email = registerDto.Email };
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
    }
}
