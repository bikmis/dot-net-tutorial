﻿using MyDataRepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataRepository.Contracts 
{
    public interface IStudentRepository
    {
        Student RegisterStudent(int id); 
    }
}