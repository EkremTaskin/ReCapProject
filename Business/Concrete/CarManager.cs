using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
			if (car.Description.Length > 2 && car.DailyPrice > 0)
			{
                _carDal.Add(car);
            }
			else
			{
				Console.WriteLine("Lütfen bilgileri doğru girdiğinizden emin olun !");
			}
        }

        public void Delete(Car car)
        {
            //if (true)
            //{
            _carDal.Delete(car);
            //}
        }

        public List<Car> GetAll()
        {
            //if (true)
            //{
            return _carDal.GetAll();
            //}
        }

        public Car GetById(int Id)
        {
            //if (true)
            //{
             return _carDal.GetById(p => p.Id == Id);
            //}
        }

        public void Update(Car car)
        {
            //if (true)
            //{
            _carDal.Update(car);
            //}
        }
	}
}
