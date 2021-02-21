using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Id = 6;
            car.BrandId = 3;
            car.ColorId = 1;
            car.DailyPrice = 0;
            car.Description = "Naber";
            car.ModelYear = 2020;

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car);
            foreach (var mycar in carManager.GetAll())
            {
                Console.WriteLine(mycar.ModelYear);
            }
            
        }
    }
}
