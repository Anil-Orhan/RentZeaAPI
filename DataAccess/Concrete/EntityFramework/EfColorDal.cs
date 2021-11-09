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
    public class EfColorDal:IColorDal
    {
        public void Add(Color entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var addedColor = context.Entry(entity); //eşle
                addedColor.State = EntityState.Added;//ekle
                context.SaveChanges();//kaydet
            }
        }

        public void Delete(Color entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var deletedColor = context.Entry(entity); //eşle
               deletedColor.State = EntityState.Deleted;//Sil
                context.SaveChanges();//kaydet
            }
        }

        public void Update(Color entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var updatedColor = context.Entry(entity); //eşle
                updatedColor.State = EntityState.Modified;//Güncelle
                context.SaveChanges();//kaydet
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                return filter == null
                    ? context.Set<Color>().ToList()
                    : context.Set<Color>().Where(filter).ToList();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (CarDbContext context = new CarDbContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }
    }
}
