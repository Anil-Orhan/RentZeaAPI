using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
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
        public void Add(Car car)
        {
            if(car.DailyPrice > 0)
            {
                if (car.CarID != null) 
                {
                    _ICarDal.Add(car);
                    Console.WriteLine("{0} Car Added with EF!", car.CarID);
                }
                else
                {
                    Console.WriteLine("The ID value is defined automatically. Please delete the ID value!");
                }
                
            }
            else
            {
                Console.WriteLine("Price must be greater than 0!");
            }
            
        }

        public void Delete(Car car)
        {
            _ICarDal.Delete(car);
            Console.WriteLine("{0} Car Deleted with EF!", car.CarID);
        }

       

        public List<Car> GetAll()
        {
           return _ICarDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _ICarDal.Get(p=>p.CarID == id);

        }

        public void Update(Car car)
        {
            _ICarDal.Update(car);
            Console.WriteLine("{0} Car Updated with EF!", car.CarID);
        }

        public List<CarDetailDto> GetByCarDetails()
        {

            return _ICarDal.GetByCarDetail();
        }
    }
}
