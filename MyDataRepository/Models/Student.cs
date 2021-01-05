using System;
using System.Collections.Generic;
using System.Text;

namespace MyDataRepository.Models
{
    public class Student
    {
        public int StudentId { get; set; }  //scalar property
        public string FirstName { get; set; }   //scalar property
        public string LastName { get; set; }   //scalar property
        public string Gender { get; set; }   //scalar property
        public DateTime? DOB { get; set; }   //scalar property
        public virtual Address Address { get; set; }  //reference navigation property (multiplicity of one) (the column will be Address_AddressId(fk, int, null)
        public virtual Course Course { get; set; }  //reference navigation property (multiplicity of one) (the column will be Course_CourseId(fk, int, null)
    }
}
