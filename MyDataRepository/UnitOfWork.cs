using MyDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataRepository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private SchoolContext context = new SchoolContext();
        private Repository<Student> studentRepository;
        private Repository<Course> courseRepository;
        private Repository<Subject> subjectRepository;
        private Repository<Address> addressRepository;

        public Repository<Student> StudentRepository { 
            get 
            { 
                studentRepository = new Repository<Student>(context); 
                return studentRepository; 
            } 
        }

        public Repository<Course> CourseRepository {
            get {
                courseRepository = new Repository<Course>(context);
                return courseRepository;
            }
        }
        public Repository<Subject> SubjectRepository {
            get {
                subjectRepository = new Repository<Subject>(context);
                return subjectRepository;
            }
        }
        public Repository<Address> AddressRepository {
            get {
                addressRepository = new Repository<Address>(context);
                return addressRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
