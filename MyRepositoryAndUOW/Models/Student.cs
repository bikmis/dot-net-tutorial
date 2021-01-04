using System;
using System.Collections.Generic;
using System.Text;

namespace MyRepositoryAndUOW.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? DOB { get; set; }
    }
}
