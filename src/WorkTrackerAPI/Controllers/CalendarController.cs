using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Net;
using System;
using WorkTrackerAPI.Infrastructure.Contracts;
using WorkTrackerAPI.Model;

namespace WorkTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : ControllerBase
    {

        private string connection = @"Server = MYSQL5042.site4now.net; Database=db_a8e1b8_worktra;Uid=a8e1b8_worktra;Pwd=worktracker1";
        private MySqlConnection db;
        private readonly ILoggerManager _logger;

        public CalendarController(ILoggerManager logger)
        {
            _logger = logger;
            db = new MySqlConnection(connection);

            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
        }

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
            return listCalendar;
        }

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
        }

    }
}
