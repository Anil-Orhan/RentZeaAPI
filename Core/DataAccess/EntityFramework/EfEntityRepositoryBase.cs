using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Abstract;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Core.Concrete
{
   public class EfEntityRepositoryBase<TEntity,TContext> :IEntityRepository<TEntity>
        where TEntity:class,IEntity,new()
         where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedBrand = context.Entry(entity); //eşle
                addedBrand.State = EntityState.Added;//ekle
                context.SaveChanges();//kaydet
              
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedBrand = context.Entry(entity); //eşle
                deletedBrand.State = EntityState.Deleted;//SİL
                context.SaveChanges();//kaydet
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedBrand = context.Entry(entity); //eşle
                updatedBrand.State = EntityState.Modified;//Güncelle
                context.SaveChanges();//kaydet
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {

                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();


            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

    }
}
