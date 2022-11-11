using Dapper;
using KeyAttribute = Dapper.KeyAttribute;

namespace WorkTrackerAPI.Model
{
    public class Users

    {
        [Key]
        [IgnoreInsert]
        public int IdUser { get; set; }

        public string UserName { get; set; }

        public string SurName1 { get; set; }

        public string SurName2 { get; set; }

        public string Email { get; set; }

        public int Phone { get; set; }

        public string Department { get; set; }

        public bool Status { get; set; }

        public int UserTypeId { get; set; }

        public string Password { get; set; }

        public int NHollidays { get; set; }

       




    }
}
