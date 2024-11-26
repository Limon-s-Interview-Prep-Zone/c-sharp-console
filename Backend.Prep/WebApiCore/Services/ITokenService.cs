using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using WebApiCore.Entities;
using WebApiCore.Request;
using WebApiCore.Response;

namespace WebApiCore.Services;

public interface ITokenService
{
    string CreateTokenAsync(AppUser user, bool fullScope);
    Task<string> CreateRefreshTokenAsync(AppUser user, bool fullScope);
    Task<TokenResponse> VerifyTokenAsync(RefreshTokenRequest request);
    Task SetUserSession(string userId);
    Task RemoveUserSession(string userId);
}

public class TokenService : ITokenService
{
    private readonly IConfiguration _configuration;
    private readonly SymmetricSecurityKey key;

    public TokenService(IConfiguration configuration)
    {
        _configuration = configuration;
        key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Token:SecretKey"]));
    }

    public string CreateTokenAsync(AppUser user, bool fullScope)
    {
        throw new NotImplementedException();
    }

    public async Task<string> CreateRefreshTokenAsync(AppUser user, bool fullScope)
    {
        var claims = GenerateClaim(user);
        throw new NotImplementedException();
    }

    public async Task<TokenResponse> VerifyTokenAsync(RefreshTokenRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task SetUserSession(string userId)
    {
        throw new NotImplementedException();
    }

    public async Task RemoveUserSession(string userId)
    {
        throw new NotImplementedException();
    }

    private static IEnumerable<Claim> GenerateClaim(AppUser user,
        IReadOnlyCollection<CachedClaim> previousClaims = default, bool fullScope = false)
    {
        // This block will check if the user request for access token using refresh token
        if (previousClaims != null)
        {
            var newClaims = previousClaims.Select(cachedClaim => new Claim(cachedClaim.Type, cachedClaim.Value))
                .ToList();
            return newClaims;
        }

        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, user.UserName),
            new(ClaimTypes.Role, "Admin"),
            new("Permission", "ViewDashboard")
        };
        return claims;
    }
}