﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataWithEF6.Entities
{
    public class BaseEntityStringKey : BaseEntity
    {
        public string Id { get; set; }
    }
}