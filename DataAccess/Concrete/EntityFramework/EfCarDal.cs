using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal:ICarDal
    {
        public void Add(Car entity)
        {
            using (CarDbContext context=new CarDbContext())
            {
                var addedCar = context.Entry(entity); //eşle
                addedCar.State = EntityState.Added;//ekle
                context.SaveChanges();//kaydet
            }
        }

        public void Delete(Car entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var deletedCar = context.Entry(entity); //eşle
                deletedCar.State = EntityState.Deleted;//sil
                context.SaveChanges();//kaydet
            }
        }

        public void Update(Car entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var updatedCar = context.Entry(entity); //eşle
                updatedCar.State = EntityState.Modified;//Güncelle
                context.SaveChanges();//kaydet
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDbContext context=new CarDbContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
            
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarDbContext context = new CarDbContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }
    }
}
