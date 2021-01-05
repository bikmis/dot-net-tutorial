using System;
using System.Collections.Generic;
using System.Text;

namespace MyDataRepository.Entities
{
    public class Address
    {
        public int AddressId { get; set; }   //scalar property
        public string HouseNumber { get; set; }  //scalar property
        public string Street { get; set; }  //scalar property
        public string City { get; set; }   //scalar property
        public string State { get; set; }  //scalar property
        public string ZipCode { get; set; }  //scalar property
        public ICollection<Student> Students { get; set; }  //collection navigation property (multiplicity of many) --> this will create Address_AddressId foreign key in Students table even if "public virtual Address Address { get; set; }" does not exist in Student table
    }
}
