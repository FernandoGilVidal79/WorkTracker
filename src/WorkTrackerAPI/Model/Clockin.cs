using Dapper;
using System;
using KeyAttribute = Dapper.KeyAttribute;

namespace WorkTrackerAPI.Model
{
    public class Clockin 
    {
        [Key]
        [IgnoreInsert]
        public int idClockIn { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime? FinishHour { get; set; }   
        public int ClockinTypeId { get; set; }
        public int UserId { get; set; }
    }
}