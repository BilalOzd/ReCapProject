using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (SampleDatabaseContext context = new SampleDatabaseContext())//belleği temizliyor, performans artıyor
            {               
                var addedEntity = context.Entry(entity);//referansı yakalama
                addedEntity.State = EntityState.Added;//ekleme
                context.SaveChanges();               
            }
            //dispose: "using" içindeki işlem bittikten sonra bellekten siler ve performansı artırır.
        }

        public void Delete(Car entity)
        {
            using (SampleDatabaseContext context = new SampleDatabaseContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (SampleDatabaseContext context = new SampleDatabaseContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (SampleDatabaseContext context = new SampleDatabaseContext())
            {
                return filter == null
                   ? context.Set<Car>().ToList()                //filtrelenmemişse bütün ürünleri,
                   : context.Set<Car>().Where(filter).ToList(); //filtre koyulmuşsa o ürünleri getir demek 
            }
        }

        public void Update(Car entity)
        {
            using (SampleDatabaseContext context = new SampleDatabaseContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
