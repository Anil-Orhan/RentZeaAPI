using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entities.DTOs;

namespace Business.Concrete
{
   public class CarManager : ICarManager
    {
        ICarDal _ICarDal;
        public CarManager(ICarDal ICarDal)
        {
            _ICarDal = ICarDal;
            
        }
        public IResult Add(Car car)
        {
            if(car.DailyPrice > 0)
            {
                if (car.CarID == null) 
                {

                    _ICarDal.Add(car);
                    return new SuccessResult(Messages.carAdded);
                    Console.WriteLine("{0} Car Added with EF!", car.CarID);
                }
                else
                {
                    return new ErrorResult(Messages.IdError);
                    Console.WriteLine(Messages.IdError);
                }
                
            }
            else
            {
                return new ErrorResult(Messages.carPriceError);
                Console.WriteLine(Messages.carPriceError);
               
            }
            
        }

        public DataResult<Car> Delete(Car car)
        {

            _ICarDal.Delete(car);
            Console.WriteLine("{0} Car Deleted with EF!", car.CarID);
            return new SuccessDataResult<Car>(car, Messages.carDeleted);

        }

        public DataResult<List<Car>> GetAll()
        {

            return new SuccessDataResult<List<Car>>(_ICarDal.GetAll(),Messages.carListed);
        }

        public DataResult<Car> GetById(int id)
        {
            var result = _ICarDal.Get(p => p.CarID == id);
            if (result==null)
            {
                return new ErrorDataResult<Car>(result, "Data is Null");
            }
            return new SuccessDataResult<Car>(Messages.carById);

        }

        public DataResult<Car> Update(Car car)
        {
            _ICarDal.Update(car);
            Console.WriteLine("{0} Car Updated with EF!", car.CarID);
            return new SuccessDataResult<Car>(Messages.carUpdated);
        }

        public DataResult<List<CarDetailDto>> GetByCarDetails()
        {
            
            return new SuccessDataResult<List<CarDetailDto>>(_ICarDal.GetByCarDetail(),Messages.carDetail);
        }
    }
}
