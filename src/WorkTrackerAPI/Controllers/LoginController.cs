using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Net;
using WorkTrackerAPI.Model;
using WorkTrackerAPI.Services.Contracts;

namespace WorkTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IAuthService authService;

        public LoginController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpGet("Token")]
        [ProducesResponseType(typeof(String), (int)HttpStatusCode.OK)]
        [SwaggerOperation("Token")]
        public string Token(string username, string password)
        {
            if (authService.ValidateLogin(username, password))
            {
                var fechaActual = DateTime.UtcNow;
                var validez = TimeSpan.FromHours(5);
                var fechaExpiracion = fechaActual.Add(validez);

                var token = authService.GenerateToken(fechaActual, username, validez);
                return token;
            }
            return "";
           
        }
    }
}
