using Dapper;

namespace WorkTrackerAPI.Model
{
    public class Calendar
    {
        [Key]
        [IgnoreInsert]
        public int IdCalendar { get; set; } 
        public int Day {  get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public bool Festive { get; set; }
    }
}