namespace secretpoc.Models
{
    public class SetupAuthenticatorViewModel
    {
        public string SecretKey { get; set; }
        public string QrCodeUrl { get; set; }
        public string Code { get; set; }
        public string AuthenticatorUri { get; set; } = string.Empty;
    }
}



