using MyDataWithEF6.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDataWithEF6.Entities
{
    public class Subject : BaseEntityIntKey
    {
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
