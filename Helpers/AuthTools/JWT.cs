namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Helpers.AuthTools;

public class JWT
{    public string SecretKey { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string DurationInMinutes { get; set; }
}
