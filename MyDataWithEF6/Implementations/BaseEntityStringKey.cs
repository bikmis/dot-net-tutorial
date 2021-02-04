using MyDataWithEF6.Entities;
using MyDataWithEF6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataWithEF6.Implementations
{
    public class BaseEntityStringKey : BaseEntity, IBaseEntity<string>
    {
        public string Id { get; set; }
    }
}
