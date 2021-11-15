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
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());



            rentalManager.Add(new Rental {CarID = 45,CustomerID = 7,RentDate = DateTime.Now,ReturnDate = DateTime.Parse("2021.11.18")});














        }
    }
}
