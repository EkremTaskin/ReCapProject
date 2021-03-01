using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities;
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
        
        [SecuredOperation("car.Add,admin")]
        [ValidationAspect(typeof(CarValidator))]
		public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Message.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Message.CarDeleted);
        }

		public IDataResult<Car> Get(int id)
		{
            return new SuccessDataResult<Car>(_carDal.Get(i=>i.Id == id));
		}

		public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Message.CarListed);
        }

        public IDataResult<Car> GetById(int Id)
        {
            return new SuccessDataResult<Car>(_carDal.GetById(p=>p.Id==Id),Message.CarListed);
        }

		public IDataResult<List<CarDetailDto>> GetCarDetails()
		{
            return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarDetails(),Message.CarListed);
		}

		public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Message.CarUpdated);
        }
	}
}
