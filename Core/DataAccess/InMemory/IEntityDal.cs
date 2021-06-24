using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Core.DataAccess.InMemory
{
    public interface IEntityDal<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        void Add(T entity);
    }
}
