﻿using MyDataWithEF6.Entities;
using MyDataWithEF6.Interfaces;
using System;

namespace MyDataWithEF6.Implementations
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private SchoolContext context;
        public UnitOfWork(string connectionString)
        {
            context = new SchoolContextFactory(connectionString).Create();
        }

        private Repository<Student> studentRepository;
        private Repository<Course> courseRepository;
        private Repository<Subject> subjectRepository;
        private Repository<Address> addressRepository;

        public Repository<Student> StudentRepository
        {
            get
            {
                studentRepository = new Repository<Student>(context);
                return studentRepository;
            }
        }

        public Repository<Course> CourseRepository
        {
            get
            {
                courseRepository = new Repository<Course>(context);
                return courseRepository;
            }
        }
        public Repository<Subject> SubjectRepository
        {
            get
            {
                subjectRepository = new Repository<Subject>(context);
                return subjectRepository;
            }
        }
        public Repository<Address> AddressRepository
        {
            get
            {
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