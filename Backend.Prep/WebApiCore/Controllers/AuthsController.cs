using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using WebApiCore.Options;
using WebApiCore.Request;

namespace WebApiCore.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthsController : ControllerBase
{
    private readonly ILogger<AuthsController> _logger;
    private readonly JwtSettings _jwtSettings;

    public AuthsController(ILogger<AuthsController> logger, JwtSettings jwtSettings)
    {
        _logger = logger;
        _jwtSettings = jwtSettings;
    }

    [HttpPost]
    public async Task<ActionResult> LoginAsync([FromBody] LoginRequest request)
    {
        if (request.UserName != request.Password && string.IsNullOrWhiteSpace(request.UserName))
            return Unauthorized(new { Message = "Invalid credentials" });

        var claims = new List<Claim>()
        {
            new Claim(JwtRegisteredClaimNames.Name, "limon"),
            new Claim(ClaimTypes.Role, "User")
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            _jwtSettings.Issuer,
            _jwtSettings.Audiences.First(),
            claims,
            expires: DateTime.UtcNow.AddMinutes(_jwtSettings.ExpireInMinutes),
            signingCredentials: creds);

        var accessToken = new JwtSecurityTokenHandler().WriteToken(token);
        var refreshToken= Guid.NewGuid().ToString();

        Response.Cookies.Append("accessToken", accessToken, new CookieOptions
        {
            HttpOnly = true,
            Secure = true, // Use Secure cookies in production
            SameSite = SameSiteMode.Strict,
            Expires = DateTime.UtcNow.AddMinutes(15)
        });
        
        Response.Cookies.Append("refreshToken", refreshToken, new CookieOptions
        {
            HttpOnly = true,
            Secure = true,
            SameSite = SameSiteMode.Strict,
            Expires = DateTime.UtcNow.AddDays(7) // Refresh token lifetime
        });


        return Ok(new
        {
            AccessToken = accessToken, // Return token in response
            RefreshToken = refreshToken, // Optionally return refresh token
            Message = "Login successful"
        });
    }
    
    [HttpPost("refresh-token")]
    public IActionResult RefreshToken()
    {
        var refreshToken = Request.Cookies["refreshToken"];
        if (string.IsNullOrEmpty(refreshToken))
        {
            return Unauthorized(new { Message = "No refresh token found" });
        }

        // Validate the refresh token (e.g., check it against the database)
        var isValid = true; // Replace with actual validation logic
        if (!isValid)
        {
            return Unauthorized(new { Message = "Invalid refresh token" });
        }

        var claims = new List<Claim>()
        {
            new Claim(ClaimTypes.Name, "limon"),
            new Claim(ClaimTypes.Role, "User")
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            _jwtSettings.Issuer,
            _jwtSettings.Audiences.First(),
            claims,
            expires: DateTime.UtcNow.AddMinutes(_jwtSettings.ExpireInMinutes),
            signingCredentials: creds);

        var newAccessToken = new JwtSecurityTokenHandler().WriteToken(token);

        Response.Cookies.Append("accessToken", newAccessToken, new CookieOptions
        {
            HttpOnly = true,
            Secure = true,
            SameSite = SameSiteMode.Strict,
            Expires = DateTime.UtcNow.AddMinutes(15)
        });

        
        return Ok(new
        {
            AccessToken = newAccessToken, // Return token in response
            RefreshToken = refreshToken, // Optionally return refresh token
            Message = "Refresh successful"
        });
    }
}