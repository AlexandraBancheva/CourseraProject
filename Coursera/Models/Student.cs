using System.ComponentModel.DataAnnotations;

namespace Coursera.Models
{
    public class Student
    {
        public Student()
        {
            this.StudentCourses = new List<StudentCourse>();
        }

        [Key]
        public string PIN { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public DateTime Time_Created { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
