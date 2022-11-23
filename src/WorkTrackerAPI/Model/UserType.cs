using System.ComponentModel.DataAnnotations;

namespace WorkTrackerAPI.Model
{
    /// <summary>
    /// Usertype Model
    /// </summary>
    public class UserType
    {
        [Key]
        public int IdUserType { get; set; }
        public string Description { get; set; }
    }
}