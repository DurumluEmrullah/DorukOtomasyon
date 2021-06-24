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
    public class ResonStopManager:IResonStopService
    {
        private IResonStopDal _resonStopDal;

        public ResonStopManager(IResonStopDal resonStopDal)
        {
            _resonStopDal = resonStopDal;
        }
        public IDataResult<List<ResonStop>> GetAll()
        {
            return new SuccessDataResult<List<ResonStop>>(_resonStopDal.getAll(), "Duruş nedenleri listelendi");
        }

        public IResult Add(ResonStop entity)
        {
            _resonStopDal.Add(entity);
            return new SuccessResult("Yeni duruş nedeni eklendi.");
        }

        public IResult Update(ResonStop entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(ResonStop entity)
        {
            throw new NotImplementedException();
        }
    }
}
