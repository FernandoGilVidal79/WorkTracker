using Dapper;
using System;

namespace WorkTrackerAPI.Model
{
    /// <summary>
    /// Log Model
    /// </summary>
    public class Log
    {
        [Key]
        [IgnoreInsert]
        public int Id { get; set; }
        public string Application { get; set; }
        public DateTime Logged { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
        public string Logger { get; set; }
        public string Callsite { get; set; }
    }
}