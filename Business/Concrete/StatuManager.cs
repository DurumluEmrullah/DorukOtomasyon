using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StatuManager:IStatuService
    {
        private IStatuDal _statuDal;

        public StatuManager(IStatuDal statuDal)
        {
            _statuDal = statuDal;
        }
        public IDataResult<List<Statu>> GetAll()
        {
            return new SuccessDataResult<List<Statu>>(_statuDal.getAll(), "Duruşlar listelendi");
        }

        public IResult Add(Statu entity)
        {
            _statuDal.Add(entity);
            return new SuccessResult("Yeni Duruş Eklendi.");
        }

        public IResult Update(Statu entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Statu entity)
        {
            throw new NotImplementedException();
        }
    }
}
