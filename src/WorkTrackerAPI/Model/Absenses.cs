﻿using System;
using Dapper;
using KeyAttribute = Dapper.KeyAttribute;

namespace WorkTrackerAPI.Model
{
    /// <summary>
    /// Absenses Model
    /// </summary>
    public class Absenses
    {
        [Key]
        [IgnoreInsert]
        public int IdAbsenses { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public bool Status { get; set; }  

        public int UserId { get; set; }

        public int AbsensesTypeId { get; set; }

    }
}
