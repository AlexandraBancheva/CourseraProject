using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coursera.Models
{
    public class Course
    {
        public Course()
        {
            this.StudentCourses = new List<StudentCourse>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey(nameof(Instructor))]
        public int Instructor_Id { get; set; }
        public virtual Instructor Instructor { get; set; }

        public int TotalTime { get; set; }

        public int Credit { get; set; }
        public DateTime Time_Created { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
