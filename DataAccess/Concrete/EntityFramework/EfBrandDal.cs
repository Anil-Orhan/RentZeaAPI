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
   public class EfBrandDal:IBrandDal
    {
        public void Add(Brand entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var addedBrand = context.Entry(entity); //eşle
                addedBrand.State = EntityState.Added;//ekle
                context.SaveChanges();//kaydet
            }
        }

        public void Delete(Brand entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var deletedBrand = context.Entry(entity); //eşle
                deletedBrand.State = EntityState.Deleted;//SİL
                context.SaveChanges();//kaydet
            }
        }

        public void Update(Brand entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var updatedBrand = context.Entry(entity); //eşle
                updatedBrand.State = EntityState.Modified;//Güncelle
                context.SaveChanges();//kaydet
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (CarDbContext context=new CarDbContext())
            {

                return filter == null
                    ? context.Set<Brand>().ToList()
                    : context.Set<Brand>().Where(filter).ToList();


            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (CarDbContext context = new CarDbContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }
    }
}
