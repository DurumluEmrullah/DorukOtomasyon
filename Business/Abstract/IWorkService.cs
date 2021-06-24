using System;
using System.Collections.Generic;
using System.Text;
using Core.Business.Abstract;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IWorkService:IBaseService<Work>
    {
        IDataResult<List<WorkDetailDto>> GetAllWorkDetails();
    }
}
