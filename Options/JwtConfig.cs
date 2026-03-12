namespace Likeprotech_gateway.Options
{
    public class JwtConfig
    {
        public string Issuer { get; set; } = null!;
        public string Audience { get; set; } = null!;
        public string SecretKey { get; set; } = null!;
        public int ExpirationMinutes { get; set; } = 60;
    }
}
