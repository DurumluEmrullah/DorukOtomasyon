using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Core.DataAccess.InMemory
{
    public class EntityBaseDal<T>:IEntityDal<T> where T : class, IEntity, new()
    {
        public List<T> getAll()
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
