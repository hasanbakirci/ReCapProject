﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
                Console.WriteLine("Günlük kiralama bedeli 0'dan büyük olmalı :" + car.DailyPrice);
            
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            //throw new NotImplementedException();
            return _carDal.GetCarDetails();
        }
    }
}
