
using System.ComponentModel.DataAnnotations;

namespace Coursera.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public DateTime Time_Created { get; set; }
    }
}
