namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Helpers.AuthTools;

public class Autorizacion
{    public enum AuthorizationRoles
    {
        Admin,
        Gerente,
        Empleado
    }

    public const AuthorizationRoles rol_predeterminado = AuthorizationRoles.Admin;
}
