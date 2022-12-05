using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Net;
using WorkTrackerAPI.Infrastructure;
using WorkTrackerAPI.Infrastructure.Contracts;
using WorkTrackerAPI.Model;

namespace WorkTrackerAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : ControllerBase
    {

        private string connection;
        private MySqlConnection db;
        private readonly ILoggerManager _logger;

        public CalendarController(ILoggerManager logger, IOptions<ConnectionStringList> connectionStrings)
        {
            connection = connectionStrings.Value.connectionString;
            _logger = logger;
            db = new MySqlConnection(connection);
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        [ProducesResponseType(typeof(IEnumerable<Calendar>), (int)HttpStatusCode.OK)]
        [HttpGet("GetFestiveByYear/{year}")]
        public IEnumerable<Calendar> GetFestiveByYear(int year)
        {
            List<Calendar> listCalendar = null;
            try
            {
                listCalendar = (List<Calendar>)SimpleCRUD.GetList<Calendar>(db, $"where year = {year}");
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
            return listCalendar;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="festive"></param>
        [HttpPut("CreateFestive")]
        public void Put([FromBody] Calendar festive)
        {
            try
            {
                SimpleCRUD.Insert(db, festive);
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
        }

    }
}