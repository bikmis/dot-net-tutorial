using MyDataWithEF6.Entities;
using MyDataWithEF6.Implementations;
using System;

namespace MyDataWithEF6.Interfaces
{
    public interface IUnitOfWork : IDisposable, IStudentRepository
    {
        Repository<Student> StudentRepository { get; }
        Repository<Course> CourseRepository { get; }
        Repository<Subject> SubjectRepository { get; }
        Repository<Address> AddressRepository { get; }
        void Save();
    }
}
