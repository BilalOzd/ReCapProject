using System;
using System.Collections.Generic;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System.Linq;
using DataAccess.Concrete.EntityFramework;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());


            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }

            System.Console.WriteLine("--------------------------------------------");

            foreach (var car in carManager.GetById(3))
            {
                System.Console.WriteLine(car.Description);
                System.Console.WriteLine(car.DailyPrice);
            }



            //InMemoryCarDal newCar = new InMemoryCarDal();
            //var result = newCar.Find()
            //System.Console.WriteLine(result);
        }
    }
}
