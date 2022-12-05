using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using WorkTrackerAPI.Infrastructure;
using WorkTrackerAPI.Infrastructure.Contracts;
using WorkTrackerAPI.Model;

namespace WorkTrackerAPI.Controllers
{
    /// <summary>
    /// Controller Usuarios
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private static string connection;
        private MySqlConnection db;

        /// <summary>
        /// Constructor Usuarios
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="connectionStrings"></param>
        public UserController(ILoggerManager logger, IOptions<ConnectionStringList> connectionStrings)
        {
            connection = connectionStrings.Value.connectionString;
            _logger = logger;       
            db = new MySqlConnection(connection);
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
        }

        /// <summary>
        /// Obtiene Usuarios
        /// </summary>
        /// <returns>User Collection</returns>
        [HttpGet("GetUsers")]
        [ProducesResponseType(typeof(IEnumerable<Users>), (int)HttpStatusCode.OK)]
        [SwaggerOperation("GetUsers")]
        public IEnumerable<Users> GetUsers()
        {
            IEnumerable<Users> listUser = null;
            try
            {           
                listUser = SimpleCRUD.GetList<Users>(db);             
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            finally
            {
                db.Close();
              
            }
            return listUser;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUserTypes")]
        [ProducesResponseType(typeof(IEnumerable<UserType>), (int)HttpStatusCode.OK)]
        [SwaggerOperation("GetUserTypes")]
        public IEnumerable<UserType> GetUserTypes()
        {
            IEnumerable<UserType> listUserType = null;
            try
            {
                listUserType = SimpleCRUD.GetList<UserType>(db);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            finally
            {
                db.Close();

            }
            return listUserType;
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
            try
            {
                user.Add(SimpleCRUD.Get<Users>(db, id));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            finally
            {
                db.Close();

            }
            return user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [HttpDelete("DeleteUser/{id}")]
        public bool DeleteUser(string id)
        {
            List<Users> user = new List<Users>();
            try
            {
                user.Add(SimpleCRUD.Get<Users>(db, id));
                user.FirstOrDefault().Status = false;
                SimpleCRUD.Update(db, user.First());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            finally
            {
                db.Close();
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpGet("Login")]
        [ProducesResponseType(typeof(Users), (int)HttpStatusCode.OK)]
        public Users Login(string userName, string password)
        {
            List<Users> users = null;
            try
            {
                users = (List<Users>)SimpleCRUD.GetList<Users>(db, $"where email = '{userName}' and password = '{password}'");
                if (users.Count() > 0)
                {
                    return users.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
            finally
            {
                db.Close();
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        [HttpPost("UpdateUser")]
        [SwaggerOperation("UpdateUser")]
        public void UpdateUser([FromBody] Users value)
        {
            try
            {
                var user = SimpleCRUD.Get<Users>(db, value.IdUser);
                user.Name = value.Name;
                user.SurName1 = value.SurName1;
                user.SurName2 = value.SurName2;
                user.Status = value.Status;
                user.Email = value.Email;
                user.Department = value.Department;
                user.Phone = value.Phone;
                user.Password = value.Password;
                SimpleCRUD.Update(db, user);
                _logger.LogInfo("Usuario actualizado correctamente. Id:" + user.IdUser);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);            
                throw;
            }
            finally
            {
                db.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        [HttpPut("CreateUser")]
        [SwaggerOperation("CreateUser")]
        public void CreateUser([FromBody] Users user)
        {
            try
            {
                SimpleCRUD.Insert(db, user);
                _logger.LogInfo("Usuario creado correctamente. " + user.IdUser);
            }

            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
            finally
            {
                db.Close();
            }
        }
    }
}