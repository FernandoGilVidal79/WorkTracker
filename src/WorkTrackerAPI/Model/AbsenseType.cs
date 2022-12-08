using System.ComponentModel.DataAnnotations;

namespace WorkTrackerAPI.Model
{
    /// <summary>
    /// Usertype Model
    /// </summary>
    public class AbsenceType
    {
        [Key]
        public int idAbsenceType { get; set; }

        public string Description { get; set; }
    }
}