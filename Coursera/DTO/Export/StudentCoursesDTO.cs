namespace Coursera.DTO.Export
{
    public class StudentCoursesDTO
    {
        public string Name { get; set; }

        public int TotalTime { get; set; }

        public int Credit { get; set; }

        // Instructor name
        public InstructorDTO InstructorName { get; set; }
    }
}
