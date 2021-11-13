using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
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
                if (car.CarID != null) 
                {

                    _ICarDal.Add(car);
                    return new SuccessResult();
                    Console.WriteLine("{0} Car Added with EF!", car.CarID);
                }
                else
                {
                    return new ErrorResult();
                    Console.WriteLine("The ID value is defined automatically. Please delete the ID value!");
                }
                
            }
            else
            {
                return new ErrorResult();
                Console.WriteLine("Price must be greater than 0!");
               
            }
            
        }

        public IDataResult<Car> Delete(Car car)
        {

            _ICarDal.Delete(car);
            Console.WriteLine("{0} Car Deleted with EF!", car.CarID);
            return new SuccessDataResult<Car>(car, "Deleted!");

        }

       

        public IDataResult<List<Car>> GetAll()
        {

            return new SuccessDataResult<List<Car>>(_ICarDal.GetAll(),"Data Listed!");
        }

        public IDataResult<Car> GetById(int id)
        {
            ;
            return new SuccessDataResult<Car>(_ICarDal.Get(p => p.CarID == id));

        }

        public IResult Update(Car car)
        {
            ;
            Console.WriteLine("{0} Car Updated with EF!", car.CarID);
            return new SuccessDataResult<Car>();
        }

        public IDataResult<List<CarDetailDto>> GetByCarDetails()
        {
            
            return new SuccessDataResult<List<CarDetailDto>>(_ICarDal.GetByCarDetail());
        }
    }
}
