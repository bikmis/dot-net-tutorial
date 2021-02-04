using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataWithEF6.Interfaces
{
    public interface IBaseEntity<TKey>
    {
        TKey Id { get; set; }
        DateTime CreatedDatetime { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDatetime { get; set; }
        string UpdatedBy { get; set; }
        DateTime? DeletedDatetime { get; set; }
        string DeletedBy { get; set; }
    }
}
