namespace Coursera.Models
{
    public class Course
    {
        public Course()
        {
            this.StudentCourses = new List<StudentCourse>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public int TotalTime { get; set; }

        public int Credit { get; set; }
        public DateTime TimeCreated { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
