using System;
using Dapper;
using KeyAttribute = Dapper.KeyAttribute;

namespace WorkTrackerAPI.Model
{
    /// <summary>
    /// Absences Model
    /// </summary>
    public class Absences
    {
        [Key]
        [IgnoreInsert]
        public int IdAbsences { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public bool Aproved { get; set; }  

        public bool Denied { get; set; }

        public int UserId { get; set; }

        public int AbsencesTypeId { get; set; }
    }
}