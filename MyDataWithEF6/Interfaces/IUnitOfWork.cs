using MyDataWithEF6.Entities;
using MyDataWithEF6.Implementations;

namespace MyDataWithEF6.Interfaces
{
    public interface IUnitOfWork : IStudentRepository
    {
        Repository<Student> StudentRepository { get; }
        Repository<Course> CourseRepository { get; }
        Repository<Subject> SubjectRepository { get; }
        Repository<Address> AddressRepository { get; }
        void Save();
    }
}
