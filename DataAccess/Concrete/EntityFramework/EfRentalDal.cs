using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (var context = new CarDbContext())
            {
                var result = from r in context.Rentals
                   
                    join user in context.Users on r.CustomerID equals user.UserID 
                    join car in context.Cars on r.CarID equals car.CarID
                    join brand in context.Brands on car.BrandID equals brand.BrandID
                    select new RentalDetailDto
                    {
                        RentalID = r.RentalID,
                        BrandName = brand.BrandName,
                        FullName = user.FirstName +" "+ user.LastName,
                        RentDate = r.RentDate,
                        ReturnDate = r.ReturnDate
                    };

                return result.ToList();
            }
        }
    }
}

