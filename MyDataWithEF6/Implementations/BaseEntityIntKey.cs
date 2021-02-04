using MyDataWithEF6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataWithEF6.Implementations
{
    public class BaseEntityIntKey : IBaseEntity<int>
    {
        public int Id { get; set; }
        public DateTime CreatedDatetime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDatetime { get; set; }
        public string DeletedBy { get; set; }
    }
}
