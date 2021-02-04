using MyDataWithEF6.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataWithEF6.Interfaces
{
    public interface IBaseEntity<TKey>
    {
        [Key]
        TKey Id { get; set; }
    }
}
