using System;
using System.ComponentModel.DataAnnotations;

namespace WorkTrackerAPI.Model
{
    public class Clockin
    {

        [Key]
        public int idClockIn { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime FinishHour { get; set; }   
        public int ClockinTypeId { get; set; }

        public int UserId { get; set; }
    }
}
