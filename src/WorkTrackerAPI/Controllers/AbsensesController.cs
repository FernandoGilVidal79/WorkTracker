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
    [Route("api/[controller]")]
    [ApiController]
    public class AbsensesController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private string connection;
        private MySqlConnection db;

        public AbsensesController(ILoggerManager logger, IOptions<ConnectionStringList> connectionStrings)
        {
            connection = connectionStrings.Value.connectionString;
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
                throw;
            }
            finally
            {
                db.Close();
            }
            return listAbsenses;
        }

        [HttpGet("ValidateAbsensesById/{id}")]
        [ProducesResponseType(typeof(Absenses), (int)HttpStatusCode.OK)]
        public Absenses ValidateAbsensesById(int id)
        {
            try
            {
                var absense = SimpleCRUD.Get<Absenses>(db, id);
                if (absense != null) 
                { 
                    absense.Aproved = true;
                    absense.Denied  = false;
                    SimpleCRUD.Update<Absenses>(db, absense);
                    _logger.LogInfo($"-- Valida la ausencia {id}");
                }
                return absense; 
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

        [HttpGet("DenegateAbsensesById/{id}")]
        [ProducesResponseType(typeof(Absenses), (int)HttpStatusCode.OK)]
        public Absenses DenegateAbsensesById(int id)
        {
            try
            {
                var absense = SimpleCRUD.Get<Absenses>(db, id);
                if (absense != null)
                {
                    absense.Aproved = false;
                    absense.Denied  = true;
                    SimpleCRUD.Update<Absenses>(db, absense);
                }
                return absense;
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

        [HttpGet("GetAbsensesTypes")]
        [ProducesResponseType(typeof(IEnumerable<AbsenseType>), (int)HttpStatusCode.OK)]
        [SwaggerOperation("GetAbsensesTypes")]
        public IEnumerable<AbsenseType> GetAbsensesTypes()
        {
            IEnumerable<AbsenseType> listAbsensesType = null;
            try
            {
                listAbsensesType = db.GetList<AbsenseType>();
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
            return listAbsensesType;
        }

        // POST api/<AbsensesController>
        [HttpPost]
        public void Post([FromBody] Absenses value)
        {
            try
            {
                var absenses = SimpleCRUD.Get<Absenses>(db, value.IdAbsenses);
                absenses.Aproved = value.Aproved;
                absenses.Denied = value.Denied;
                absenses.StartDate = value.StartDate;
                absenses.AbsensesTypeId = value.AbsensesTypeId;
                absenses.FinishDate = value.FinishDate;
                SimpleCRUD.Update(db, absenses);
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

        [HttpPut("CreateAbsense")]
        public void Put([FromBody] Absenses absense)
        {
            try
            {
                SimpleCRUD.Insert(db, absense);
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