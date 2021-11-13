using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;

namespace Business.Abstract
{
   public interface IManagerService<T> where T: class,new()
    {
        IResult Add(T entity);
        IDataResult<T> Delete(T entity);
        IResult Update(T entity);
        IDataResult<List<T>> GetAll();
        IDataResult<T> GetById(int i);
    }
}
