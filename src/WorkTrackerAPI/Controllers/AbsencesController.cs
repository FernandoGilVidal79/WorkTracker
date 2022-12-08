using Dapper;
using Microsoft.AspNetCore.Authorization;
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
    public class AbsencesController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private string connection;
        private MySqlConnection db;

        public AbsencesController(ILoggerManager logger, IOptions<ConnectionStringList> connectionStrings)
        {
            connection = connectionStrings.Value.connectionString;
            _logger = logger;
            db = new MySqlConnection(connection);
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
        }

        [ProducesResponseType(typeof(IEnumerable<Absences>), (int)HttpStatusCode.OK)]
        [HttpGet("GetAbsencesByUserId/{id}")]
        public IEnumerable<Absences> GetAbsencesByUserId(int id)
        {
            List<Absences> listAbsences = null;
            try
            {
                listAbsences = (List<Absences>)SimpleCRUD.GetList<Absences>(db, $"where userid = {id}");
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
            return listAbsences;
        }

        [HttpGet("ValidateAbsencesById/{id}")]
        [ProducesResponseType(typeof(Absences), (int)HttpStatusCode.OK)]
        public Absences ValidateAbsencesById(int id)
        {
            try
            {
                var absense = SimpleCRUD.Get<Absences>(db, id);
                if (absense != null) 
                { 
                    absense.Aproved = true;
                    absense.Denied  = false;
                    SimpleCRUD.Update<Absences>(db, absense);
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

        [HttpGet("DenegateAbsencesById/{id}")]
        [ProducesResponseType(typeof(Absences), (int)HttpStatusCode.OK)]
        public Absences DenegateAbsencesById(int id)
        {
            try
            {
                var absense = SimpleCRUD.Get<Absences>(db, id);
                if (absense != null)
                {
                    absense.Aproved = false;
                    absense.Denied  = true;
                    SimpleCRUD.Update<Absences>(db, absense);
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

        [HttpGet("GetAbsencesTypes")]
        [ProducesResponseType(typeof(IEnumerable<AbsenceType>), (int)HttpStatusCode.OK)]
        [SwaggerOperation("GetAbsencesTypes")]
        public IEnumerable<AbsenceType> GetAbsencesTypes()
        {
            IEnumerable<AbsenceType> listAbsencesType = null;
            try
            {
                listAbsencesType = db.GetList<AbsenceType>();
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
            return listAbsencesType;
        }

        // POST api/<AbsencesController>
        [HttpPost]
        public void Post([FromBody] Absences value)
        {
            try
            {
                var Absences = SimpleCRUD.Get<Absences>(db, value.IdAbsences);
                Absences.Aproved = value.Aproved;
                Absences.Denied = value.Denied;
                Absences.StartDate = value.StartDate;
                Absences.AbsencesTypeId = value.AbsencesTypeId;
                Absences.FinishDate = value.FinishDate;
                SimpleCRUD.Update(db, Absences);
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

        [HttpPut("CreateAbsence")]
        public void Put([FromBody] Absences absence)
        {
            try
            {
                SimpleCRUD.Insert(db, absence);
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