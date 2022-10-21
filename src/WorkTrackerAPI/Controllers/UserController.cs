using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Net;
using WorkTrackerAPI.Model;

namespace WorkTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {


        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //[ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        //[SwaggerOperation("GetUsers")]
        //public IEnumerable<User> GetUsers()
        //{
        //    var listUser = new List<User>();
        //    listUser.Add(new Model.User()
        //    {
        //        IdUser = 1,
        //        Name = "Fernando",
        //        Department =  "RRHH",
        //        Email ="fgil@wotktracker.com",
        //        Phone = "67633300",
        //        Surname1 = "Gil",
        //        Surname2 = "Vidal",      

        //    });

        //    return listUser;
        //}


        /// <summary>
        /// Metodo para obtener usuarios
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [SwaggerOperation("GetUsers")]
        public IEnumerable<User> GetUserById(string id)
        {
            var listUser = new List<User>();
            listUser.Add(new Model.User()
            {
                IdUser = 1,
                Name = "Fernando",
                Department = "RRHH",
                Email = "fgil@wotktracker.com",
                Phone = "67633300",
                Surname1 = "Gil",
                Surname2 = "Vidal",

            });

            return listUser;
        }

        [HttpDelete]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [SwaggerOperation("DeleteUser")]
        public bool DeleteUser(string id)
        {

            bool OK = true;
            return OK;
        }

        [HttpPost]
        [ProducesResponseType(typeof(User), (int)HttpStatusCode.OK)]
        [SwaggerOperation("UpdateUser")]
        public User UpdateUser(User user)
        {
            return new Model.User()
            {
                IdUser = 1,
                Name = "Fernando",
                Department = "RRHH",
                Email = "fgil@wotktracker.com",
                Phone = "67633300",
                Surname1 = "Gil",
                Surname2 = "Vidal",

            };

        }
    }
}
