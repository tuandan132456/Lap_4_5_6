﻿using BigSchool.Models;
using System.Linq;

namespace BigSchool.Controllers
{
    internal class CoursesViewModel
    {
        public IQueryable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}