using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Net;
using WorkTrackerAPI.Infrastructure.Contracts;
using WorkTrackerAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbsensesController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private string connection = @"Server = MYSQL5042.site4now.net; Database=db_a8e1b8_worktra;Uid=a8e1b8_worktra;Pwd=worktracker1";
        private MySqlConnection db;

        public AbsensesController(ILoggerManager logger)
        {
            _logger = logger;
            db = new MySqlConnection(connection);
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
        }

        [ProducesResponseType(typeof(IEnumerable<Absenses>), (int)HttpStatusCode.OK)]
        [HttpGet("GetAbsensesByUserId/{id}")]
        public IEnumerable<Absenses> GetAbsensesByUserId(int id)
        {
            List<Absenses> listAbsenses = null;
            try
            {
                listAbsenses = (List<Absenses>)SimpleCRUD.GetList<Absenses>(db, $"where userid = {id}");
            }

            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return listAbsenses;

        }

        [HttpGet("GetAbsensesTypes")]
        [ProducesResponseType(typeof(IEnumerable<AbsenseType>), (int)HttpStatusCode.OK)]
        [SwaggerOperation("GetAbsensesTypes")]
        public IEnumerable<AbsenseType> GetAbsensesTypes()
        {
            IEnumerable<AbsenseType> listAbsensesType = db.GetList<AbsenseType>();
            return listAbsensesType;
        }

        // POST api/<AbsensesController>
        [HttpPost]
        public void Post([FromBody] Absenses value)
        {

            var absenses = SimpleCRUD.Get<Absenses>(db, value.IdAbsenses);
            absenses.Status = value.Status;
            absenses.StartDate = value.StartDate;
            absenses.AbsensesTypeId = value.AbsensesTypeId;
            absenses.FinishDate = value.FinishDate;
            SimpleCRUD.Update(db, absenses);
                

        }

        // PUT api/<AbsensesController>/5
        [HttpPut("CreateAbsense")]
        public void Put( [FromBody] Absenses absense)
        {
            try
            {

                SimpleCRUD.Insert(db, absense);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        // DELETE api/<AbsensesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
