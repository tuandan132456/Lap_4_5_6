using BigSchool.Models;
using System.Collections.Generic;

namespace BigSchool.Controllers
{
    internal class CourseViewModel
    {
        public List<Category> Categories { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public string Place { get; set; }
    }
}