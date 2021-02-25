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
			RentalManager rentalManager = new RentalManager(new EfRentalDal());
			rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = DateTime.Now });
			
			//foreach (var car in carManager.GetCarDetails().Data)
			//{
			//	Console.WriteLine("Id : {0} BrandName : {1}  ColorName : {2}  DailyPrice : {3}" ,car.CarId , car.BrandName , car.ColorName , car.DailyPrice );
			//}

			//var result = carManager.GetCarDetails();

			//if (result.Success == true)
			//{
			//	foreach (var car in result.Data)
			//	{
			//		Console.WriteLine(car.BrandName + "/" + car.ColorName);
			//	}
			//}
			//else
			//{
			//	Console.WriteLine(result.Message);
			//}

			//RentalManager rentalManager = new RentalManager(new EfRentalDal());
			//rentalManager.Add(new Rental { CarId = 5008, CustomerId = 2, RentDate = DateTime.Now.AddDays(-2) });
			//rentalManager.Update(new Rental {Id =13 ,CarId = 5008 , CustomerId = 2 , RentDate= new DateTime(2001,05,1), ReturnDate = new DateTime(2004,01,04)});
			//var result = rentalManager.Add(new Rental{CarId = 5008 , CustomerId = 1 , RentDate = new DateTime (2021 , 05 , 12)});

			//Console.WriteLine(result.Message);

			//CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
			//customerManager.Add(new Customer {CompanyName = "ACompany " });

			

		}

		private static void ManagersTest()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			carManager.Delete(new Car { Id = 1 });
			carManager.Add(new Car { Description = "Nice Car", ModelYear = 2002, DailyPrice = 155 });

			foreach (var car in carManager.GetAll().Data)
			{
				Console.WriteLine("Descriptions : {0}    ModelYear : {1}     DailyPrice : {2}", car.Description, car.ModelYear, car.DailyPrice);
			}

			BrandManager brandManager = new BrandManager(new EfBrandDal());
			brandManager.Add(new Brand { Name = "Honda" });

			foreach (var brand in brandManager.GetAll().Data)
			{
				Console.WriteLine("Brand : {0}", brand.Name);
			}

			ColorManager colorManager = new ColorManager(new EfColorDal());
			colorManager.Add(new Color { Name = "Black" });

			foreach (var color in colorManager.GetAll().Data)
			{
				Console.WriteLine("Name : {0}", color.Name);
			}
		}
	}
}
