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
            CarDetails();

        }

        private static void CarDetails()
        {
            CarManager carManager2 = new CarManager(new EfCarDal());
            var result = carManager2.GetCarDetails();

            foreach (var c in carManager2.GetCarDetails().Data)
            {
                Console.WriteLine("{0} -- {1} -- {2} --> {3} # {4} # ", c.ColorName, c.BrandName, c.ModelYear,result.Success,result.Message);
            }
        }

        private static void AddCar()
        {
            Car car = new Car();
            car.BrandId = 2;
            car.ColorId = 3;
            car.DailyPrice = 6;
            car.Description = "Naber3";
            car.ModelYear = 2021;

            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.Add(car);
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            foreach (var mycar in carManager.GetAll().Data)
            {
                Console.WriteLine(mycar.ModelYear);
            }
        }
    }
}
