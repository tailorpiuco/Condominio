using Condominio.Models;
using Condominio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Condominio.Business.Interfaces
{
    public interface IEntityService<T> where T : BaseEntity, IEntity
    {
        void Delete(int id);
        void Delete(T entity);
        T Insert(T entity);
        void Update(T entity);

        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
    }
}
