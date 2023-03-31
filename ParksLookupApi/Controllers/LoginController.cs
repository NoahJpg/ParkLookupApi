using System.Text;
using ParksLookupApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace ParksLookupApi.Controllers
{
  [Route("api/[controlller]")]
  [ApiController]
  public class LoginController : ControllerBase
  {
    private IConfiguration _config;
    
    public LoginController(IConfiguration config)
    {
      _config = config;
    }

    public object SecurityAlgorightms { get; private set; }

    [AllowAnonymous]
    [HttpPost]
    public IActionResult Login([FromBody] UserLogin userLogin)
    {
      var user = Authenticated(userLogin);

      if (user != null)
      {
        var token = Generate(user);
        return Ok(token);
      }

      return NotFound("User not found");
    }

    private string Generate(UserModel user)
    {
      var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
      var credentials = new SigningCredtials(securityKey, SecurityAlgorightms.HmacSha256);

      var claims = new []
      {
        new Claim(ClaimTypes.NameIdentifier, user.Username),
        new Claim(ClaimTypes.Email, user.EmailAddress),
        new Claim(ClaimTypes.GivenName, user.GivenName),
        new Claim(ClaimTypes.Surname, user.Surname),
        new Claim(ClaimTypes.Role, user.Role)
      };
    }
  }
}