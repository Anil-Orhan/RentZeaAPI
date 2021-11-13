using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager:IBrandManager
    {
        IBrandDal _brandDal ;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand entity)
        {
            _brandDal.Add(entity);
            Console.WriteLine("{0} Brand is Added with EF!", entity.BrandID);
            return new SuccessResult();
        }

        public IDataResult<Brand> Delete(Brand entity)
        {
            _brandDal.Delete(entity);
            Console.WriteLine("{0} Brand is Deleted with EF!", entity.BrandID);
            return new SuccessDataResult<Brand>();
        }

        public IResult Update(Brand entity)
        {
            _brandDal.Update(entity);
            Console.WriteLine("{0} Brand is Updated with EF!", entity.BrandID);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult <List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int brandID)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.BrandID == brandID));
        }
    }
}
