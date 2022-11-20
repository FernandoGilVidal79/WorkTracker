using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WorkTrackerAPI.Infrastructure.Contracts;
using WorkTrackerAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkTrackerAPI.Controllers
{
    [Route("api/log")]
    [ApiController]
    public class LogController : ControllerBase
    {

        private string connection = @"Server = MYSQL5042.site4now.net; Database=db_a8e1b8_worktra;Uid=a8e1b8_worktra;Pwd=worktracker1";
        private MySqlConnection db;
        private readonly ILoggerManager _logger;

        public LogController(ILoggerManager logger)
        {
            _logger = logger;
            db = new MySqlConnection(connection);
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
        }

        // GET: api/<LogController>
        [HttpGet("GetLogs")]
        [ProducesResponseType(typeof(IEnumerable<Log>), (int)HttpStatusCode.OK)]
        [SwaggerOperation("GetLogs")]
        public IEnumerable<Log> GetLogs()
        {
            IEnumerable<Log> listLogs = null;
            listLogs = SimpleCRUD.GetList<Log>(db);
            return listLogs;
        }

        [HttpGet("GetLogsByDate")]
        [ProducesResponseType(typeof(IEnumerable<Log>), (int)HttpStatusCode.OK)]
        [SwaggerOperation("GetLogsByDate")]
        public IEnumerable<Log> GetLogsByDate(DateTime date)
        {
            IEnumerable<Log> listLogs = null;
            listLogs = SimpleCRUD.GetList<Log>(db, $"where Logged > {date.ToShortDateString()} ");
            return listLogs;
        }

        // GET api/<LogController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LogController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LogController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LogController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
