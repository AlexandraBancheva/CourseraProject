﻿namespace Coursera.Models
{
    public class StudentCourse
    {
        public string PIN { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public DateTime CompletionDate { get; set; }
    }
}
