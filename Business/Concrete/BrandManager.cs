using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
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
        public void Add(Brand entity)
        {
            _brandDal.Add(entity);
            Console.WriteLine("{0} Brand is Added with EF!", entity.BrandID);
        }

        public void Delete(Brand entity)
        {
            _brandDal.Delete(entity);
            Console.WriteLine("{0} Brand is Deleted with EF!", entity.BrandID);
        }

        public void Update(Brand entity)
        {
            _brandDal.Update(entity);
            Console.WriteLine("{0} Brand is Updated with EF!", entity.BrandID);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandID)
        {
            return _brandDal.Get(p => p.BrandID == brandID);
        }
    }
}
