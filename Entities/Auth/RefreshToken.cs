using Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Entities.Users;

namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Entities.Auth;
public class RefreshToken
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public string Token { get; set; }
    public DateTime Expires { get; set; }
    public bool IsExpired => DateTime.UtcNow >= Expires;
    public DateTime Created { get; set; }
    public DateTime? Revoked { get; set; }
    public bool IsActive => Revoked == null && !IsExpired;
}
