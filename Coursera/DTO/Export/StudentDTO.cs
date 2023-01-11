namespace Coursera.DTO.Export
{
    public class StudentDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TotalCredit { get; set; }

        public StudentCoursesDTO[] StudentsCourses { get; set; }
    }
}
