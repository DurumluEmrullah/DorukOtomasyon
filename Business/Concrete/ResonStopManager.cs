using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
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
            return new SuccessDataResult<List<ResonStop>>(_resonStopDal.GetAll(), Messages.ResonStopsListed);
        }

        public IResult Add(ResonStop entity)
        {
            _resonStopDal.Add(entity);
            return new SuccessResult(Messages.ResonStopAdded);
        }

    }
}
