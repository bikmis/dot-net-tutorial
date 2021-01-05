using System;
using System.Collections.Generic;
using System.Text;

namespace MyDataRepository.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
