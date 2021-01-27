using MyDataRepository.Entities;
using MyDataRepository.Repository;

namespace MyDataRepository.UnitOfWork
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
