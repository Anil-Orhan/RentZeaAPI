using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class InsuranceManager:IInsuranceManager
    {
        private IInsuranceDal _insuranceDal;
        public InsuranceManager(IInsuranceDal insuranceDal)
        {
                _insuranceDal=insuranceDal; 
        }
        public IResult Add(Insurance entity)
        {
            _insuranceDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }

        public DataResult<Insurance> Delete(Insurance entity)
        {
            _insuranceDal.Delete(entity);
           
            return new SuccessDataResult<Insurance>(entity, Messages.Deleted);
        }

        public DataResult<Insurance> Update(Insurance entity)
        {
           _insuranceDal.Update(entity);
           return new SuccessDataResult<Insurance>(entity, Messages.Updated);
        }

        public DataResult<List<Insurance>> GetAll()
        {
           var result= _insuranceDal.GetAll();
           return new SuccessDataResult<List<Insurance>>(result, Messages.Listed);

        }

        public DataResult<Insurance> GetById(int i)
        {
           var result= _insuranceDal.Get(p => p.InsuranceId == i);
           return new SuccessDataResult<Insurance>(result);
        }
    }
}
