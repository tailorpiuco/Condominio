using Condominio.Business.Interfaces;
using Condominio.Data.Interfaces;
using Condominio.Models;
using Condominio.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Condominio.Business
{
    public class EntityService<T> : IEntityService<T> where T : BaseEntity, IEntity
    {
        IUnitOfWork _unitOfWork;
        IGenericRepository<T> _repository;

        public EntityService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public virtual void Delete(int id)
        {
            _repository.Delete(id);
            _unitOfWork.Commit();
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Delete(entity);
            _unitOfWork.Commit();
        }

        public virtual IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _repository.FindBy(predicate);
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            return _repository.FindBy(predicate, includes);
        }

        public virtual IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            return _repository.GetAll(includes);
        }

        public virtual T Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entity = _repository.Insert(entity);
            _unitOfWork.Commit();

            return entity;
        }

        public virtual void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _repository.Update(entity);
            _unitOfWork.Commit();
        }
    }
}
