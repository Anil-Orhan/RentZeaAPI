using System;
using Business.Concrete;
using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        /*
         * SQL server
         * CRUD işlemleri,
         * InMemory ve EntityFramework ile entegre çalışma,
         * Toplu listeleme,
         * her manager ile ID'ye göre sorgulama,
         * GetAll metoduna LINQ sorgusu yazarak filtreleme yapma
         
         */
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());


            foreach (var item in carDetail())
            {
                Console.WriteLine(item.BrandName);
                Console.WriteLine(item.ColorName);

            }
            





        }


        public static List<CarDetailDto> carDetail() 
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var car = carManager.GetAll();
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            List<CarDetailDto> resultList = new List<CarDetailDto>();
            foreach (var item in car.Data)
            {
                var color = colorManager.GetById(item.ColorID);
                var brand = brandManager.GetById(item.BrandID);
                CarDetailDto detail = new CarDetailDto { CarID = item.CarID, DailyPrice = item.DailyPrice, ModelYear = item.ModelYear, BrandName = brand.Data.BrandName, ColorName = color.Data.ColorName };
                resultList.Add(detail);
            }
          

            return resultList;
        }
    }
}
