using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Controllers
{
    public class CustomBaseController : Controller
    {
        public Int64 getInfoCurrentUserId()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var currentUserId = String.Empty;
            IEnumerable<Claim> claims = null;
            if (identity != null)
            {
                claims = identity.Claims;
                // or
                currentUserId = identity.FindFirst("uid").Value;

            };

            return Convert.ToInt64(currentUserId);
        }
    }
}
