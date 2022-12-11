using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using WorkTrackerAPI.Infrastructure;
using WorkTrackerAPI.Infrastructure.Contracts;
using WorkTrackerAPI.Model;

namespace WorkTrackerAPI.Controllers
{
    /// <summary>
    /// Controlador de Fichaje
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ClockInController : ControllerBase
    {
      
        private string connection;
        private MySqlConnection db;
        private readonly ILoggerManager _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger">Manejador de Log</param>
        /// <param name="connectionStrings">Cadenas de conexión</param>
        public ClockInController(ILoggerManager logger, IOptions<ConnectionStringList> connectionStrings)
        {
            connection = connectionStrings.Value.connectionString;
            _logger = logger;
            db = new MySqlConnection(connection);    
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);     
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetClockInById/{id}")]
        public Clockin GetClockInById(int id)
        {
            Clockin clockIn = null;
            try
            {
                clockIn = SimpleCRUD.Get<Clockin>(db, id);
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
            return clockIn;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetClockInsByUserId/{id}")]
        public IEnumerable<Clockin> GetClockInsByUserId(int id)
        {
            List<Clockin> listClockIn = null;
            try
            {
                listClockIn = (List<Clockin>)SimpleCRUD.GetList<Clockin>(db, $"where userid = {id} and  DATE_ADD( StartHour, INTERVAL -5 DAY )  < CURDATE() ");
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
            return listClockIn;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetClockInsTodayByUserId/{id}")]
        public IEnumerable<Clockin> GetClockInsTodayByUserId(int id)
        {
            List<Clockin> listClockIn = null;
            try
            {
                listClockIn = (List<Clockin>)SimpleCRUD.GetList<Clockin>(db, $"where userid = {id} and day(date) = day(now()) and month(date) = month(now()) and year(date) = year(now()); ");
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
            return listClockIn;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clockin"></param>
        [HttpPut("ClockIn")]
        public void Put([FromBody] Clockin clockin)
        {
            try
            {
                SimpleCRUD.Insert(db, clockin);
                _logger.LogInfo($"Usuario {clockin.UserId} ha fichado {clockin.idClockIn} , Fichaje: {clockin.ClockinTypeId}" );
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
        /// <param name="clockin"></param>
        [HttpPost("UpdateClockIn")]
        [SwaggerOperation("UpdateClockIn")]
        public void UpdateClockIn([FromBody] Clockin clockin)
        {
            try
            {
                var clockinUpdated = SimpleCRUD.Get<Clockin>(db, clockin.idClockIn);
                clockinUpdated.StartHour = clockin.StartHour;
                clockinUpdated.FinishHour = clockin.FinishHour;
                clockinUpdated.Date = clockin.Date;
                SimpleCRUD.Update(db, clockin);              
                _logger.LogInfo($"Usuario {clockin.UserId} ha actualizado el fichaje {clockin.idClockIn}, Fichaje: {clockin.ClockinTypeId} ");
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