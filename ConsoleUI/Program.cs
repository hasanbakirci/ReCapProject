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
            //AddCar();
            CarManager carManager2 = new CarManager(new EfCarDal());
            var result = carManager2.GetCarDetails();
            foreach (var c in carManager2.GetCarDetails())
            {
                Console.WriteLine("{0} -- {1} -- {2} ",c.ColorName,c.BrandName,c.ModelYear);
            }

        }

        private static void AddCar()
        {
            Car car = new Car();
            car.BrandId = 2;
            car.ColorId = 3;
            car.DailyPrice = 6;
            car.Description = "Naber2";
            car.ModelYear = 2021;

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car);
            foreach (var mycar in carManager.GetAll())
            {
                Console.WriteLine(mycar.ModelYear);
            }
        }
    }
}
