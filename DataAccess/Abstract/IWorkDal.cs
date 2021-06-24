using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.InMemory;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IWorkDal:IEntityDal<Work>
    {
        List<WorkDetailDto> getAllWorkDetail();
    }
}
