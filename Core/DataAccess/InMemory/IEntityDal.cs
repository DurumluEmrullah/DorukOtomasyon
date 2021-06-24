using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Core.DataAccess.InMemory
{
    public interface IEntityDal<T> where T : class, IEntity, new()
    {
        List<T> getAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
