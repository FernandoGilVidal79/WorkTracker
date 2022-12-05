using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Net;
using WorkTrackerAPI.Infrastructure;
using WorkTrackerAPI.Infrastructure.Contracts;
using WorkTrackerAPI.Model;


namespace WorkTrackerAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/log")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private string connection;
        private MySqlConnection db;
        private readonly ILoggerManager _logger;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="connectionStrings"></param>
        public LogController(ILoggerManager logger, IOptions<ConnectionStringList> connectionStrings)
        {
            connection = connectionStrings.Value.connectionString;
            _logger = logger;
            db = new MySqlConnection(connection);
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetLogs")]
        [ProducesResponseType(typeof(IEnumerable<Log>), (int)HttpStatusCode.OK)]
        [SwaggerOperation("GetLogs")]
        public IEnumerable<Log> GetLogs()
        {
            IEnumerable<Log> listLogs = null;
            listLogs = SimpleCRUD.GetList<Log>(db);
            return listLogs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        [HttpGet("GetLogsByDate")]
        [ProducesResponseType(typeof(IEnumerable<Log>), (int)HttpStatusCode.OK)]
        [SwaggerOperation("GetLogsByDate")]
        public IEnumerable<Log> GetLogsByDate(DateTime date)
        {
            IEnumerable<Log> listLogs = null;
            try
            {
                listLogs = SimpleCRUD.GetList<Log>(db, $"where Logged > {date.ToShortDateString()} ");
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
            return listLogs;
        }

    }
}