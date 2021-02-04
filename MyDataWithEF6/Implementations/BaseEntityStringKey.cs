using MyDataWithEF6.Entities;
using MyDataWithEF6.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataWithEF6.Implementations
{
    public class BaseEntityStringKey : BaseEntity, IBaseEntity<string>
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
    }
}
