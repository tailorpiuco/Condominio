using Condominio.Data.Interfaces;
using Condominio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Condominio.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Models.BaseEntity, IEntity
    {
        protected DbContext _dbContext;
        protected readonly IDbSet<T> _dbSet;

        public GenericRepository(DbContext context)
        {
            _dbContext = context;
            _dbSet = context.Set<T>();
        }

        public virtual T Delete(int id)
        {
            var entity = _dbSet.SingleOrDefault(e => e.Id == id);
            return this.Delete(entity);
        }

        public virtual T Delete(T entity)
        {
            return _dbSet.Remove(entity);
        }

        public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate, params System.Linq.Expressions.Expression<Func<T, object>>[] includes)
        {
            return _dbSet.IncludeMultiple(includes).Where(predicate).AsQueryable();
        }

        public IEnumerable<T> GetAll(params System.Linq.Expressions.Expression<Func<T, object>>[] includes)
        {
            return _dbSet.IncludeMultiple(includes).AsQueryable();
        }

        public T GetById(Guid id, params System.Linq.Expressions.Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public T GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public T Insert(T entity)
        {
            return InsertOrUpdate(entity);
        }

        public void Update(T entity)
        {
            InsertOrUpdate(entity);
        }

        private T InsertOrUpdate(T entity)
        {
            var item = _dbSet.Find(entity.Id);

            if (item != null)
            {
                var attachedEntry = _dbContext.Entry(item);
                attachedEntry.CurrentValues.SetValues(entity);
            }
            else
            {
                return _dbSet.Add(entity);
            }

            return item;
        }
    }
}
