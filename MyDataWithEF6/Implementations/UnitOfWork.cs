using MyDataWithEF6.Entities;
using MyDataWithEF6.Interfaces;
using System;

namespace MyDataWithEF6.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private SchoolDbContext _dbContext;
        public UnitOfWork(string connectionString)
        {
            _dbContext = new SchoolContextFactory(connectionString).Create();
        }

        private Repository<Student> studentRepository;
        private Repository<Course> courseRepository;
        private Repository<Subject> subjectRepository;
        private Repository<Address> addressRepository;

        public Repository<Student> StudentRepository
        {
            get
            {
                studentRepository = studentRepository == null ? new Repository<Student>(_dbContext) : studentRepository;
                return studentRepository;
            }
        }

        public Repository<Course> CourseRepository
        {
            get
            {
                courseRepository = courseRepository == null ? new Repository<Course>(_dbContext) : courseRepository;
                return courseRepository;
            }
        }
        public Repository<Subject> SubjectRepository
        {
            get
            {
                subjectRepository = subjectRepository == null ? new Repository<Subject>(_dbContext) : subjectRepository;
                return subjectRepository;
            }
        }
        public Repository<Address> AddressRepository
        {
            get
            {
                addressRepository = addressRepository == null ? new Repository<Address>(_dbContext) : addressRepository;
                return addressRepository;
            }
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        private bool disposed = false;

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Student RegisterStudent(int id)
        {
            var student = StudentRepository.GetById(id);
            student.Gender = "Female";
            studentRepository.Update(student);
            Save();
            // student is registered.
            return student;
        }
    }
}
