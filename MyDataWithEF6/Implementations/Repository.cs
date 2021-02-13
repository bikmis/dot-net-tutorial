using MyDataWithEF6.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MyDataWithEF6.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private SchoolDbContext _dbContext;
        private DbSet<TEntity> _dbSet;

        internal Repository(SchoolDbContext context)
        {
            _dbContext = context;
            _dbSet = context.Set<TEntity>();
        }
        // Get(filter: q=> q.id==20, orderBy: q => q.OrderBy(q => q.name)
        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, List<string> includes = null)
        {
            // The above paramenter can be replaced with (... List<string> includes = null). string includeProperties = "" is replaced.
            // Include in linq is used to include related columns. This is eager loading. 
            // var customersWithOrderDetail = context.Customers.Include("Orders").ToList(); is the same as 
            // SELECT * FROM Customers JOIN Orders ON Customers.Id = Orders.CustomerId;
            //     var stud1 = ctx.Students
            //                    .Include("Standard")
            //                    .Where(s => s.StudentName == "Bill")
            //                    .FirstOrDefault<Student>();
            // or
            //     var stud1 = ctx.Students.Include(s => s.Standard)
            //                             .Where(s => s.StudentName == "Bill")
            //                             .FirstOrDefault<Student>();
            // The following example query example load the Student, Standard and Teacher entities
            //     var stud1 = ctx.Students.Include("Standard.Teachers")
            //                             .Where(s => s.StudentName == "Bill")
            //                             .FirstOrDefault<Student>();
            // or
            //     var stud1 = ctx.Students.Include(s => s.Standard.Teachers)
            //                             .Where(s => s.StudentName == "Bill")
            //                             .FirstOrDefault<Student>();

            // Expression<Func<TEntity, bool>> filter = null --> this is an expression tree, where TEntity is a parameter and bool is a return value.

            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includes != null) {
                includes.ForEach(relatedEntity => query.Include(relatedEntity));
            }

          /*
            foreach (var relatedEntity in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(relatedEntity);
            }
          */

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
        
        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        //Call the following IsExists(q=> q.id == 20)
        public bool IsExists(Expression<Func<TEntity, bool>> expression = null) {
            IQueryable<TEntity> query = _dbSet;
            return query.Any(expression);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var entityToDelete = _dbSet.Find(id);
            if (entityToDelete != null && _dbContext.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
        }
    }
}
