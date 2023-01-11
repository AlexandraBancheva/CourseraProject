using Coursera.Data;
using Coursera.DTO.Export;
using System.Net;

public class Program
{
    private static string ResultDirectory = "../../../ResultDirectory";

    private static void Main(string[] args)
    {
        var db = new CourseraContext();
        GetAllStudentsWithCourses(db);
    }

    public static void GetAllStudentsWithCourses(CourseraContext context)
    {
        var students = new ReportDTO()
        {
            Students = context.Students.ToArray().Select(s => new StudentDTO()
            {
                StudentName = $"{s.First_Name} {s.Last_Name}",
                TotalCredit = s.StudentCourses.Where(c => c.PIN == s.PIN).Sum(cr => cr.Course.Credit),
                StudentsCourses = context.StudentCourses.Where(c => c.PIN == s.PIN).Select(co => new StudentCoursesDTO()
                {
                    Name = co.Course.Name,
                    TotalTime = co.Course.TotalTime,
                    Credit = co.Course.Credit,
                    InstructorName = $"{context.Instructors.Where(i => i.Id == co.Course.Instructor_Id).Select(n => n.First_Name)} {context.Instructors.Where(i => i.Id == co.Course.Instructor_Id).Select(n => n.Last_Name)}"
                }).ToArray()
            }).ToArray()
        };
        
    }
}