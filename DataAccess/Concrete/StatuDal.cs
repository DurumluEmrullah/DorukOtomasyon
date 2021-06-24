using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class StatuDal:IStatuDal
    {
        private List<Statu> status =new List<Statu>()
        {
            new Statu(){Id = 1,Name = "Mola"},
            new Statu(){Id = 2,Name = "Arıza"},
            new Statu(){Id = 3,Name = "Setup"},
            new Statu(){Id = 4,Name = "Arge"}

        };
        public List<Statu> GetAll()
        {
            return status;
        }

        public void Add(Statu entity)
        {
            entity.Id = status.Count + 1;
            status.Add(entity);
        }

    }
}
