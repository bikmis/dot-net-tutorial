using System;
using System.Collections.Generic;
using System.Text;

namespace MyDataWithEF6.Entities
{
    public class Course : BaseEntityInt
    {
       // public int Id { get; set; }
        public string Name { get; set; }      
        public double Tuition { get; set; } 
        public double DurationInYears { get; set; }
        public string SchoolName { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
