﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDbContext>, ICarDal
    {
        public List<CarDetailDto> GetByCarDetail()
        {
            using (CarDbContext context=new CarDbContext())
            {
                var result = from c in context.Cars
                             join cl in context.Colors on c.ColorID equals cl.ColorID
                             join b in context.Brands on c.BrandID equals b.BrandID
                             select new CarDetailDto
                             {
                                 CarID = c.CarID,
                                 ModelYear = c.ModelYear,
                                 ColorName = cl.ColorName,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                             };

                return result.ToList();
            }

        }

      
        public CarDetailDto GetByCarDetailSingle(int carID)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from c in context.Cars
                    join cl in context.Colors on c.ColorID equals cl.ColorID
                    join b in context.Brands on c.BrandID equals b.BrandID
                    where c.CarID==carID
                    select new CarDetailDto
                    {
                        CarID = c.CarID,
                        ModelYear = c.ModelYear,
                        ColorName = cl.ColorName,
                        BrandName = b.BrandName,
                        DailyPrice = c.DailyPrice,
                        Description = c.Description,
                    };

                return result.SingleOrDefault();
            }
        }

        public List<CarDetailDto> GetByBrand(int brandID)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from c in context.Cars
                    join cl in context.Colors on c.ColorID equals cl.ColorID
                    join b in context.Brands on c.BrandID equals b.BrandID
                             where c.BrandID == brandID
                    select new CarDetailDto
                    {
                        CarID = c.CarID,
                        ModelYear = c.ModelYear,
                        ColorName = cl.ColorName,
                        BrandName = b.BrandName,
                        DailyPrice = c.DailyPrice,
                        Description=c.Description,
                        
                    };

                return result.ToList();
            }
        }
        public List<CarDetailDto> GetByColor(int colorID)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from c in context.Cars
                    join cl in context.Colors on c.ColorID equals cl.ColorID
                    join b in context.Brands on c.BrandID equals b.BrandID
                    where c.ColorID == colorID
                             select new CarDetailDto
                    {
                        CarID = c.CarID,
                        ModelYear = c.ModelYear,
                        ColorName = cl.ColorName,
                        BrandName = b.BrandName,
                        DailyPrice = c.DailyPrice,
                        Description = c.Description,
                        
                    };

                return result.ToList();
            }
        }
    }

}
