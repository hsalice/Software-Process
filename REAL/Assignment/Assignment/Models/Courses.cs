using System;
using System.Collections.Generic;

namespace Assignment.Models
{
    public partial class Courses
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public int? Year { get; set; }
        public int? Semester { get; set; }
    }
}
