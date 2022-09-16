using Template_EF_Dapper_JWT_Refresh_WithOutIdentity.DTOs.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Services.Interfaces
{
    public interface ITokenService
    {
        Task<ResponseAuth> GenerateAccessTokenAsync(UserCredentials model);
        Task<ResponseAuth> RefreshTokenAsync(string refreshToken);
    }
}
