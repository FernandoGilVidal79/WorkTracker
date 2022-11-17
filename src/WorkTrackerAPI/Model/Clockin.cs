using System;
using Dapper;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using KeyAttribute = Dapper.KeyAttribute;

namespace WorkTrackerAPI.Model
{
    public class Clockin 
    {

        [Key]
        [IgnoreInsert]
        public int idClockIn { get; set; }

        public DateTime Fecha { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime? FinishHour { get; set; }   
        public int ClockinTypeId { get; set; }

        public int UserId { get; set; }
    }
}