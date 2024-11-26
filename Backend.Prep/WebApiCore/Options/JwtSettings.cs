namespace WebApiCore.Options;

public class JwtSettings
{
    public string SecretKey { get; set; }
    public string Issuer { get; set; }
    public List<string> Audiences { get; set; }
    public int ExpireInMinutes { get; set; }
    public int RefreshTokenExpiresInMinutes { get; set; }
    public int MaximumUserSessionTimeInMinutes { get; set; }
}