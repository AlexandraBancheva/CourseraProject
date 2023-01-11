using Coursera.Data;
using Coursera.DTO.Export;

public class Program
{
    private static string ResultDirectory = "../../../ResultDirectory";

    private static void Main(string[] args)
    {
        var db = new CourseraContext();
    }

    public static void GetAllStudentsWithCourses(CourseraContext context)
    {
        var studentsWithCourses = new ReportDTO()
        {
            Student = (StudentDTO)context.Students.Select(s => new StudentDTO
            {
                FirstName = s.FirstName,
                LastName = s.LastName,
                TotalCredit = context.StudentCourses.Where(c => c.PIN == s.PIN).Sum(sc => sc.Course.Credit),
                StudentsCourses = s.StudentCourses.Select(c => new StudentCoursesDTO
                {
                    Name = c.Course.Name,
                    TotalTime = c.Course.TotalTime,
                    Credit = c.Course.Credit,
                    InstructorName = (InstructorDTO)context.Instructors.Select(i => new InstructorDTO
                    {
                        InstructorName = $"{i.FirstName} {i.LastName}",
                    })
                }).ToArray()
            })
        };
    }
}