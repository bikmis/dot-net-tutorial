using System;
using System.Collections.Generic;
using System.Text;

namespace MyRepositoryAndUOW.Models
{
    public class Course
    {
        public string Subject { get; set; }
        public double Tuition { get; set; } 
        public double DurationInYears { get; set; }
        public string SchoolName { get; set; }
    }
}
