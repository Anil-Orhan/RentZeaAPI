using System;
using Business.Concrete;
using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


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
            Car car1 = new Car
            {
                CarID = 1,
                DailyPrice = 150,
                BrandID = 2,
                ColorID = 2,
                Description = "Test",
                ModelYear = "1995"
            };
            Car car2 = new Car
            {
                CarID = 2,
                DailyPrice = 160,
                BrandID = 1,
                ColorID = 5,
                Description = "Test1",
                ModelYear = "2010"
            };
            //Brand brand1 = new Brand {BrandName = "BMW"};
            //Brand brand2 = new Brand { BrandName = "AUDI" };
            //Brand brand3 = new Brand { BrandName = "FORD" };
            //Brand brand4 = new Brand { BrandName = "WOLKSVAGEN" };
            //Brand brand5 = new Brand { BrandName = "OPEL" };



            //brandManager.Add(brand1);
            //brandManager.Add(brand2);
            //brandManager.Add(brand3);
            //brandManager.Add(brand4);
            //brandManager.Add(brand5);

            foreach (var item in carManager.GetByCarDetails())
            {
                Console.WriteLine("ID: {0} , Model Year : {1} , Brand : {2} , Color : {3} , Price : {4} ",item.CarID,item.ModelYear,
                    item.BrandName,item.ColorName,item.DailyPrice);
            }



        }
    }
}
