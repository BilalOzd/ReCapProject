using System;
using System.Collections.Generic;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }

            System.Console.WriteLine("--------------------------------------------");

            foreach (var car in carManager.GetById(3))
            {
                System.Console.WriteLine(car.Description);
            }
        }
    }
}
