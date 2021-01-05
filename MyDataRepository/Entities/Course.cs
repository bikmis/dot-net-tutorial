using System;
using System.Collections.Generic;
using System.Text;

namespace MyDataRepository.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }      
        public double Tuition { get; set; } 
        public double DurationInYears { get; set; }
        public string SchoolName { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }
    }
}
