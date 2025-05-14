namespace OrderService.Models
{
    public class JwtSettings
    {
        public string Authority { get; set; }
        public string Audience { get; set; }
        public string SecretKey { get; set; }
    }
}
