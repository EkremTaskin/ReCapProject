using Business.Concrete;
using System.Linq;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{

	class Program
	{
		static void Main(string[] args)
		{
			//ManagersTest();

			CarManager carManager = new CarManager(new EfCarDal());
			foreach (var car in carManager.GetCarDetails())
			{
				Console.WriteLine("Id : {0} BrandName : {1}  ColorName : {2}  DailyPrice : {3}" ,car.CarId , car.BrandName , car.ColorName , car.DailyPrice );
			}
		}

		private static void ManagersTest()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			carManager.Add(new Car { Description = "Nice Car", ModelYear = 2002, DailyPrice = 155 });

			foreach (var car in carManager.GetAll())
			{
				Console.WriteLine("Descriptions : {0}    ModelYear : {1}     DailyPrice : {2}", car.Description, car.ModelYear, car.DailyPrice);
			}

			BrandManager brandManager = new BrandManager(new EfBrandDal());
			brandManager.Add(new Brand { Name = "Honda" });

			foreach (var brand in brandManager.GetAll())
			{
				Console.WriteLine("Brand : {0}", brand.Name);
			}

			ColorManager colorManager = new ColorManager(new EfColorDal());
			colorManager.Add(new Color { Name = "Black" });

			foreach (var color in colorManager.GetAll())
			{
				Console.WriteLine("Name : {0}", color.Name);
			}
		}
	}
}
