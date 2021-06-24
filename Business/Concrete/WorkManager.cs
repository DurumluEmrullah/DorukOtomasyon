using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
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
            return new SuccessDataResult<List<Work>>(_workDal.getAll(), "İş Emirleri Listelendi.");
        }

        public IResult Add(Work entity)
        {
            _workDal.Add(entity);
            return new SuccessResult("Yeni İş Emri Eklendi.");
        }

        public IResult Update(Work entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Work entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<WorkDetailDto>> GetAllWorkDetails()
        {
            return new SuccessDataResult<List<WorkDetailDto>>(_workDal.getAllWorkDetail(), "İş emirleri listelendi.");
        }
    }
}
