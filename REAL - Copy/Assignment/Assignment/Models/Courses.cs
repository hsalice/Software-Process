using System;
using System.Collections.Generic;

namespace Assignment.Models
{
    public partial class Courses
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int? Year { get; set; }
        public int? Semester { get; set; }
        public string Prerequisite { get; set; }
        public string Compulsory { get; set; }
        public string Category { get; set; }
    }
}
