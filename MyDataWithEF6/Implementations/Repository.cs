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
        
        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            //Expression<Func<TEntity, bool>> filter = null --> this is an expression tree, where TEntity is a parameter and bool is a return value.

            IQueryable<TEntity> debSet = _dbSet;

            if (filter != null)
            {
                debSet = debSet.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                debSet = debSet.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(debSet).ToList();
            }
            else
            {
                return debSet.ToList();
            }
        }
        
        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
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
