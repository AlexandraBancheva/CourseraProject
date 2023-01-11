namespace Coursera.Models
{
    public class Student
    {
        public Student()
        {
            this.StudentCourses = new List<StudentCourse>();
        }

        public string PIN { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime TimeCreated { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
