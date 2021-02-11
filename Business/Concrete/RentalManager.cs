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
			var result = _rentalDal.GetAll(r => r.CarId == rental.CarId);

			for (int i = 0; i < result.Count; i++)
			{
				if (result[i].ReturnDate == null || result[i].RentDate > result[i].ReturnDate)
				{
					return new ErrorResult("Bu araba henüz teslim edilmedi");
				}
			}

			_rentalDal.Add(rental);
			return new SuccessResult("Araba kiralanması eklendi");
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
