using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class WorkManager:IWorkService
    {
        private IWorkDal _workDal;

        public WorkManager(IWorkDal workDal)
        {
            _workDal = workDal;
        }

        public IDataResult<List<Work>> GetAll()
        {
            return new SuccessDataResult<List<Work>>(_workDal.GetAll(), Messages.WorksListed);
        }

        public IResult Add(Work entity)
        {
            _workDal.Add(entity);
            return new SuccessResult(Messages.WorkAdded);
        }

        public IDataResult<List<WorkDetailDto>> GetAllWorkDetails()
        {
            return new SuccessDataResult<List<WorkDetailDto>>(_workDal.GetAllWorkDetail(), Messages.WorksListed);
        }
    }
}
