using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class RentalManager : IRentalService
	{
		private IRentalDal _rentalDal;

		public RentalManager(IRentalDal rentalDal)
		{
			_rentalDal = rentalDal;
		}
		[ValidationAspect(typeof(RentalValidator))]
		public IResult Add(Rental rental)
		{
			var result = _rentalDal.GetById(p=>p.CarId == rental.CarId && (p.ReturnDate == null || p.ReturnDate > DateTime.Now));

			if (result != null)
			{
				return new ErrorResult("Araba hala kullanılıyor");
			}

			_rentalDal.Add(rental);
			return new SuccessResult("Araba Eklendi");
		}

		public IResult Delete(Rental rental)
		{
			_rentalDal.Delete(rental);
			return new SuccessResult();
		}

		public IDataResult<Rental> GetById(int id)
		{
			return new SuccessDataResult<Rental>(_rentalDal.GetById(p => p.Id == id));
		}

		public IDataResult<List<Rental>> GetAll()
		{
			return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
		}

		public IResult Update(Rental rental)
		{
			_rentalDal.Update(rental);
			return new SuccessResult();
		}
	}
}
