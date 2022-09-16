using System.ComponentModel.DataAnnotations;

namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity.DTOs.Authorization;

public class RegisterDTO
{
    [Required]
    public string Nombres { get; set; }
    [Required]
    public string ApellidoPaterno { get; set; }
    [Required]
    public string ApellidoMaterno { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
}
