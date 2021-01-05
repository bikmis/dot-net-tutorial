using MyDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataRepository
{
    public interface IUnitOfWork
    {
        Repository<Student> StudentRepository { get; }
        Repository<Course> CourseRepository { get; }
        Repository<Subject> SubjectRepository { get; }
        Repository<Address> AddressRepository { get; }
        void Save();
    }
}
