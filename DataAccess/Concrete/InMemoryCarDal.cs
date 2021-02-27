using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=220000, Description="Honda Civic", ModelYear=2018},
                new Car{Id=2, BrandId=2, ColorId=2, DailyPrice=290000, Description="Volkswagen Passat", ModelYear=2017},
                new Car{Id=3, BrandId=2, ColorId=1, DailyPrice=190000, Description="Volkswagen Golf", ModelYear=2016},
                new Car{Id=4, BrandId=3, ColorId=3, DailyPrice=250000, Description="Toyota Corolla", ModelYear=2020},
                new Car{Id=5, BrandId=4, ColorId=3, DailyPrice=110000, Description="Hyundai Accent Blue", ModelYear=2014}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id); // LINQ
            _cars.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id); //foreach yerine tek staırlık bu kodu kullanıyoruz - LINQ
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList(); //"Where belirlenen duruma göre LİSTE oluşturur"
        }

    }
}
