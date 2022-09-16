namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Entities.Users;
public class UsuariosRoles
{
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public int RolId { get; set; }
    public Rol Rol { get; set; }
}
