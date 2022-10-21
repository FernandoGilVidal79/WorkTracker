using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTrackerAPI.Model
{
    public class User

    {

        public int IdUser { get; set; }

        public string Name { get; set; }

        public string Surname1 { get; set; }

        public string Surname2 { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Department { get; set; }

        public bool Status { get; set; }


    }
}
