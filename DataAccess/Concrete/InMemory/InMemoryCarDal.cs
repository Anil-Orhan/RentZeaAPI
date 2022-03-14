using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryCarDal : ICarDal
    {
        List<Car> _Cars;

        public InMemoryCarDal()
        {
            _Cars = new List<Car>();
        }
       
        public void Add(Car car)
        {
            _Cars.Add(car);
            Console.WriteLine("ID: {0} Car Added!",car.CarID);
        }

        public void Delete(Car car)
        {
            _Cars.Remove(car);
            Console.WriteLine("ID: {0} Car Deleted!", car.CarID);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetByCarDetail()
        {
            throw new NotImplementedException();
        }

        public CarDetailDto GetByCarDetailSingle(int carID)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetByBrand(int brandID)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetByColor(int colorID)
        {
            throw new NotImplementedException();
        }


        public Car Get(int ID)
        {
            var result=new Car();
            foreach (var item in _Cars)
            {
                if (item.CarID == ID) { result= item; }
               
              
                  
            }
            return result;
        }

        public List<Car> GetAll()
        {

            return _Cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            foreach (var item in _Cars)
            {
                if (item.CarID == car.CarID)
                {
                    item.ModelYear = car.ModelYear;
                    item.DailyPrice = car.DailyPrice;
                    item.ColorID = car.ColorID;
                    item.BrandID = car.BrandID;
                    item.Description = car.Description;
                
                
                }
            }
        }
    }
}
