using Template_EF_Dapper_JWT_Refresh_WithOutIdentity.DTOs.Authorization;
using Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Services.Interfaces
{
    public interface IUserService
    {
        Task<Usuario> GetByRefreshTokenAsync(string refreshToken);
        Task<Usuario> GetByUserNameAsync(string username);
        Task<string> RegisterAsync(RegisterDTO registerDto);
        Task revokeRefreshToken();
        Task<Usuario> ValidateUserAsync(UserCredentials userCredentials);
    }
}
