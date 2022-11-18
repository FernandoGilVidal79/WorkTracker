using System.ComponentModel.DataAnnotations;

namespace WorkTrackerAPI.Model
{
    /// <summary>
    /// Usertype Model
    /// </summary>
    public class AbsenseType
    {
        [Key]
        public int idAbsenseType { get; set; }

        public string Description { get; set; }
    }
}
