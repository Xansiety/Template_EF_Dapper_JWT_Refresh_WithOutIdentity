namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Helpers.Errors;
public class ExceptionAPI : ResponseAPI
{
    public ExceptionAPI(int statusCode, string message = null, string details = null) : base(statusCode, message)
    {
        Details = details;
    }
    public string Details { get; set; }
}
