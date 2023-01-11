namespace Coursera.DTO.Export
{
    public class StudentDTO
    {
        public string StudentName { get; set; }
        public int TotalCredit { get; set; }

        public StudentCoursesDTO[] StudentsCourses { get; set; }
    }
}
