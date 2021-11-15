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
    public class CustomerManager:ICustomerManager
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer entity)
        {
            _customerDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }

        public DataResult<Customer> Delete(Customer entity)
        {
            _customerDal.Delete(entity);
            return new SuccessDataResult<Customer>(entity, Messages.Deleted);

        }

        public DataResult<Customer> Update(Customer entity)
        {
            _customerDal.Update(entity);
            return new SuccessDataResult<Customer>(Messages.Updated);
        }

        public DataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.Listed);
        }

        public DataResult<Customer> GetById(int i)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.UserID == i));
        }
    }
}
