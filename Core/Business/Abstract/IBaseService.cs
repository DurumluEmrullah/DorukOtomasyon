using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;

namespace Core.Business.Abstract
{
    public interface IBaseService<T>
    {
        IDataResult<List<T>> GetAll();
        IResult Add(T entity);

    }
}
