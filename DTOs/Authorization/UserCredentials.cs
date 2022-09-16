using System.ComponentModel.DataAnnotations;

namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity.DTOs.Authorization;

public class UserCredentials
{
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
}
