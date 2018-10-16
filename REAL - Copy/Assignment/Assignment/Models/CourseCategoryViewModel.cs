using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment.Models
    {
        public class CourseCategoryViewModel
        {
            public List<Courses> course;
            public SelectList categories;
            public string courseCategory { get; set; }
        }
    }

