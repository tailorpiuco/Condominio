using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Condominio.Data.Interfaces
{
    public interface IGenericRepository<T> where T : Models.BaseEntity
    {
        T Delete(int id);
        T Delete(T entity);
        T Insert(T entity);
        void Update(T entity);

        T GetById(Guid id, params Expression<Func<T, object>>[] includes);
        T GetById(Guid id);

        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes);        
    }
}
