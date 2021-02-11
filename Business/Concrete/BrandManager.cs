using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class BrandManager : IBrandService
	{
		IBrandDal _brandDal;
		public BrandManager(IBrandDal brandDal)
		{
			_brandDal = brandDal;
		}

		public IResult Add(Brand brand)
		{
			throw new NotImplementedException();
		}

		public IResult Delete(Brand brand)
		{
			throw new NotImplementedException();
		}

		public IDataResult<Brand> Get(int id)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Brand>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IResult Update(Brand brand)
		{
			throw new NotImplementedException();
		}
	}
}
