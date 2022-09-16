using Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Helpers.Errors;
using Microsoft.AspNetCore.Mvc;

namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Controllers
{
    [Route("errors/{code}")] 
    public class ErrorsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ResponseAPI(code));
        }
    }
}
