namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Helpers.Errors;

public class ValidationAPI : ResponseAPI
{
    public ValidationAPI() : base(400)
    {

    }

    public IEnumerable<string> Errors { get; set; }
}
