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
            //CarDetails();
            //ColorGetAll();
            //BrandGetAll();
            //ColorAdd();
            //BrandAdd();
            //CarGetAll();
            //CarDelete();
            //CarGetById();
            //UserAdd();
            //UserGetAll();
            //CustomerGetAll();
            //CustomerAdd();
            //RentalGetAll();
            //RentalAdd();
            RentalUpdate();
        }

        private static void RentalUpdate()
        {
            Rental rental = new Rental();
            rental.Id = 1;
            rental.ReturnDate = DateTime.Today;
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Update(rental);
            Console.WriteLine(result.Message);
            RentalGetAll();
        }

        private static void RentalAdd()
        {
            Rental rental = new Rental();
            rental.CarId = 1;
            rental.CustomerId = 1;
            rental.RentDate = DateTime.Today;
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(rental);
            Console.WriteLine(result.Message);
            RentalGetAll();
        }

        private static void RentalGetAll()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll();
            foreach (var r in result.Data)
            {
                Console.WriteLine("{0} -> {1} - {2} - {3} / {4}", r.Id, r.CustomerId, r.CarId, r.RentDate,r.ReturnDate);
            }
        }

        private static void CustomerAdd()
        {
            Customer customer = new Customer();
            customer.UserId = 1;
            customer.CompanyName = "Ha San";
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(customer);
            CustomerGetAll();
        }

        private static void CustomerGetAll()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetAll();
            foreach (var r in result.Data)
            {
                Console.WriteLine("{0} -> {1} - {2}", r.Id, r.UserId, r.CompanyName);
            }
        }

        private static void UserGetAll()
        {
            UserManager carManager = new UserManager(new EfUserDal());
            var result = carManager.GetAll();
            foreach (var r in result.Data)
            {
                Console.WriteLine("{0} -> {1} - {2} - {3} ", r.Id, r.FirstName, r.LastName, r.Email);
            }
        }

        private static void UserAdd()
        {
            User user = new User();
            user.FirstName = "Hasan";
            user.LastName = "Bakirci";
            user.Email = "hasan@gmail.com";
            user.Password = "12345";
            UserManager carManager = new UserManager(new EfUserDal());
            carManager.Add(user);
            UserGetAll();
        }

        private static void CarGetById()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetById(5);
            Console.WriteLine("{0} -- {1} -- {2} - ", result.Data.Id, result.Data.ModelYear, result.Data.Description);
        }

        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car();
            car.Id = 8;
            carManager.Delete(car);
            CarGetAll();
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            foreach (var c in result.Data)
            {
                Console.WriteLine(" {0} -- {1} -- {2} ", c.Id, c.ModelYear, c.Description);
            }
        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();
            brand.BrandName = "BMW";
            brandManager.Add(brand);
            BrandGetAll();
        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color();
            color.ColorName = "Pembe";
            colorManager.Add(color);
            ColorGetAll();
        }

        private static void BrandGetAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            foreach (var b in result.Data)
            {
                Console.WriteLine("--> " + b.BrandName);
            }
        }

        private static void ColorGetAll()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            foreach (var c in result.Data)
            {
                Console.WriteLine("--> " + c.ColorName);
            }
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
