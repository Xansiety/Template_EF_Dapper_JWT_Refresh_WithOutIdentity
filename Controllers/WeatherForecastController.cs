using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Helpers.AuthTools.Autorizacion;

namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Controllers
{
    [ApiController]
    [Route("api/testing")]
    public class WeatherForecastController : CustomBaseController
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }



        [HttpGet("admin-route")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        public ActionResult Get()
        {

            var id = getInfoCurrentUserId();
            return Ok(new { currentUserId = id });
        }


        [HttpGet("unprotected-route")]
        public ActionResult anonimo()
        {

            return Ok(new
            {
                ok = true,
                msg = "Hola esta es una respuesta JSON",
                Data = "Ruta no protegida"
            });
        }


        [HttpGet("protected-route")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public ActionResult autorizado()
        {

            return Ok(new
            {
                ok = true,
                msg = "Hola esta es una respuesta JSON",
                Data = "Ruta no protegida"
            });
        }
    }
}