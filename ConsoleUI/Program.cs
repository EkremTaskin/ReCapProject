using Business.Concrete;
using System.Linq;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
<<<<<<< HEAD
	class Program
	{
		static void Main(string[] args)
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
=======
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car {Description = "Nice Car" , ModelYear = 2002 , DailyPrice = 155 });

			foreach (var car in carManager.GetAll())
			{
				Console.WriteLine("Descriptions : {0}    ModelYear : {1}     DailyPrice : {2}", car.Description , car.ModelYear , car.DailyPrice);
			}

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand {Name = "Honda"});

			foreach (var brand in brandManager.GetAll())
			{
                Console.WriteLine("Brand : {0}", brand.Name);
            }

            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color {Name = "Black" });

			foreach (var color in colorManager.GetAll())
			{
				Console.WriteLine("Name : {0}" , color.Name);
			}
        }
    }
>>>>>>> c800f627bf9f33000f414da30df7f42daa81783f
}
