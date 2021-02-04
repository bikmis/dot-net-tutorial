using System;
using System.Collections.Generic;
using System.Text;

namespace MyDataWithEF6.Entities
{
    public class Subject : BaseEntity
    {
       // public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
