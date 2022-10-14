using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            var listUser = new List<User>();
            listUser.Add(new Model.User()
            {
                IdUser = 1,
                Name = "fernando"
            });

            return listUser;
        }
    }
}
