using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MyDataRepository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal SchoolContext _context;
        internal DbSet<TEntity> _dbSet;

        public Repository(SchoolContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        TEntity IRepository<TEntity>.GetById(int id)
        {
            return _dbSet.Find(id);
        }

        IEnumerable<TEntity> IRepository<TEntity>.GetAll()
        {
            return _dbSet.ToList();
        }

        void IRepository<TEntity>.Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        void IRepository<TEntity>.Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        void IRepository<TEntity>.Delete(int id)
        {
            var entityToDelete = _dbSet.Find(id);
            if (entityToDelete != null && _context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
        }
    }
}
