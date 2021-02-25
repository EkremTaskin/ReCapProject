using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        public InMemoryCarDal()
        {

        }

		public void Add(Car entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Car entity)
		{
			throw new NotImplementedException();
		}

		public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public bool Get(Expression<Func<Car, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public List<CarDetailDto> GetCarDetails()
		{
			throw new NotImplementedException();
		}

		public void Update(Car entity)
		{
			throw new NotImplementedException();
		}

		public Car GetById(Expression<Func<Car, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		Car IEntityRepository<Car>.Get(Expression<Func<Car, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public bool Any(Expression<Func<Car, bool>> filter = null)
		{
			throw new NotImplementedException();
		}
	}
}
