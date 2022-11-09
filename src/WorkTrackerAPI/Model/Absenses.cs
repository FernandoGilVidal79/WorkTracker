using System;

namespace WorkTrackerAPI.Model
{
    public class Absenses
    {
        public int IdAbsenses { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public bool Status { get; set; }  

        public int UserId { get; set; }

        public int AbsensesTypeId { get; set; }

    }
}
