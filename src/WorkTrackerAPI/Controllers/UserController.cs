using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Swashbuckle.AspNetCore.Annotations;
using System;
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

        [HttpGet("GetUsers")]
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
        [HttpGet("GetUserById/{id}")]
        [ProducesResponseType(typeof(IEnumerable<Users>), (int)HttpStatusCode.OK)]
        [SwaggerOperation("GetUserById/{id}")]
        public IEnumerable<Users> GetUserById(string id)
        {
            List<Users> user = new List<Users>();
            user.Add(SimpleCRUD.Get<Users>(db, id));
            return user;
        }

        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [HttpDelete("DeleteUser/{id}")]
        public bool DeleteUser(string id)
        {
            List<Users> user = new List<Users>();
            user.Add(SimpleCRUD.Get<Users>(db, id));
            user.FirstOrDefault().Status = false;
            SimpleCRUD.Update<Users>(db, user.First());
            return true;
        }
        [HttpGet("Login")]
        [ProducesResponseType(typeof(Users), (int)HttpStatusCode.OK)]
        public Users Login(string userName, string password)
        {
            List<Users> users = null;
            try
            {
                users = (List<Users>)SimpleCRUD.GetList<Users>(db, $"where UserName = '{userName}' and password = '{password}'");


                if (users.Count() > 0)
                {
                    return users.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
        }

        [HttpPost("UpdateUser")]
        [SwaggerOperation("UpdateUser")]
        public void UpdateUser([FromBody] Users value)
        {
          
           var user = SimpleCRUD.Get<Users>(db, value.IdUser);
            user.UserName    = value.UserName;
            user.SurName1    = value.SurName1;
            user.SurName2    = value.SurName2;
            user.Status      = value.Status;
            user.Email       = value.Email;
            user.Department  = value.Department;
            user.Phone       = value.Phone;
            user.Password    = value.Password;
            SimpleCRUD.Update<Users>(db, user);
        }


        // PUT api/<ClockInController>/5
        [HttpPut("CreateUser")]
        [SwaggerOperation("CreateUser")]
        public void CreateUser([FromBody] Users user)
        {
            SimpleCRUD.Insert(db, user);
        }


    }
}
