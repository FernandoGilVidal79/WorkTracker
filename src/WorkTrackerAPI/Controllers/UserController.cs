using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using WorkTrackerAPI.Model;

namespace WorkTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private string connection = @"Server = MYSQL5042.site4now.net; Database=db_a8e1b8_worktra;Uid=a8e1b8_worktra;Pwd=worktracker1";
        private MySqlConnection db;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
            db = new MySqlConnection(connection);
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
        }

        [HttpGet]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [SwaggerOperation("GetUsers")]
        public IEnumerable<Users> GetUsers()
        { 
            IEnumerable<Users> listUser = null;     
            listUser = SimpleCRUD.GetList<Users>(db);
            return listUser;
        }


        /// <summary>
        /// Metodo para obtener usuarios
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
   
        public IEnumerable<Users> GetUserById(string id)
        {
            List<Users> user = new List<Users>();
            user.Add(SimpleCRUD.Get<Users>(db, id));
            return user;
        }

        [HttpDelete]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [SwaggerOperation("DeleteUser")]
        public bool DeleteUser(string id)
        {
            List<Users> user = new List<Users>();
            user.Add(SimpleCRUD.Get<Users>(db, id));
            user.FirstOrDefault().Status = false;
            SimpleCRUD.Update<Users>(db, user.First());
            return true;
        }
        [HttpGet("{userName}")]
        public Users Login(string userName, string password)
        {
            List<Users> user = new List<Users>();
            return SimpleCRUD.Get<Users>(db, $"where userName = {userName}" );
        }

        [HttpPost]
        public void Post([FromBody] Users value)
        {
          
           var user = SimpleCRUD.Get<Users>(db, value.IdUser);
            user.UserName    = value.UserName;
            user.SurName1    = value.SurName1;
            user.SurName2    = value.SurName2;
            user.Status      = value.Status;
            user.Email       = value.Email;
            user.Departement = value.Departement;
            user.Phone       = value.Phone;
            SimpleCRUD.Update<Users>(db, user);
        }


        // PUT api/<ClockInController>/5
        [HttpPut("{id}")]
        public void PutUser([FromBody] Users user)
        {
            SimpleCRUD.Insert<Users>(db, user);
        }


    }
}
