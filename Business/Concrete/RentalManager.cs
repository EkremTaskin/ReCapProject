using Business.Abstract;
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

		public IResult Add(Rental rental)
		{
			var result = _rentalDal.GetById(p => p.CarId == rental.CarId);

			if (result != null && result.ReturnDate == null)
			{
				return new ErrorResult("Bu araç hala kullanılıyor");
			}

			_rentalDal.Add(rental);
			result.ReturnDate = null;
			return new SuccessResult();
		}

		public IResult Delete(Rental rental)
		{
			_rentalDal.Delete(rental);
			return new SuccessResult();
		}

		public IDataResult<Rental> Get(int id)
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
