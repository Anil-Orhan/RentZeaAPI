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
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager:IRentalManager
    {
        private IRentalDal _rentalDal;

        public RentalManager( IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental entity)
        {
            
            if (entity.ReturnDate.Equals(""))
            {
                _rentalDal.Add(entity);
                return new SuccessResult(Messages.Added);
            }
            else
            {
                return new ErrorResult(Messages.Error);
            }
           
        }

        public DataResult<Rental> Delete(Rental entity)
        {
            _rentalDal.Delete(entity);
            return new SuccessDataResult<Rental>(entity, Messages.Deleted);
        }

        public DataResult<Rental> Update(Rental entity)
        {
            _rentalDal.Update(entity);
            return new SuccessDataResult<Rental>(Messages.Updated);
        }

        public DataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.Listed);

        }

        public DataResult<Rental> GetById(int i)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.RentalID == i));
        }

        public DataResult<List<RentalDetailDto>> GetRentalDetails()
        {

            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetail(), Messages.carDetail);
        }
    }
}
