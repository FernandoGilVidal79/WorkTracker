using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using WorkTrackerAPI.Infrastructure.Contracts;
using WorkTrackerAPI.Model;

namespace WorkTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClockInController : ControllerBase
    {
      
        private string connection = @"Server = MYSQL5042.site4now.net; Database=db_a8e1b8_worktra;Uid=a8e1b8_worktra;Pwd=worktracker1";
        private MySqlConnection db;
        private readonly ILoggerManager _logger;

        public ClockInController(ILoggerManager logger)
        {
            _logger = logger;
            db = new MySqlConnection(connection);
            
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
        }

        // GET: api/<ClockInController>
        [HttpGet("GetClockInById/{id}")]
        public Clockin GetClockInById(int id)
        {
            Clockin clockIn = null;
            clockIn = SimpleCRUD.Get<Clockin>(db, id);    
            return clockIn;
        }

        // GET api/<ClockInController>/5
        [HttpGet("GetClockInsByUserId/{id}")]
        public IEnumerable<Clockin> GetClockInsByUserId(int id)
        {
            List<Clockin> listClockIn = null;
            try
            {
                listClockIn = (List<Clockin>)SimpleCRUD.GetList<Clockin>(db, $"where userid = {id} and StartHour > CURDATE() ");
            }

            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
            return listClockIn;
        }

        // PUT api/<ClockInController>/5
        [HttpPut("ClockIn")]
        public void Put([FromBody] Clockin clockin)
        {
            try
            {
                SimpleCRUD.Insert(db, clockin);
                _logger.LogInfo($"Usuario {clockin.UserId} ha fichado {clockin.idClockIn}" );
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }      
    }
}