using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }

<<<<<<< HEAD
		public int BrandId { get; set; }

		public int ColorId { get; set; }

		public int ModelYear { get; set; }
=======
        public int ModelYear { get; set; }
>>>>>>> c800f627bf9f33000f414da30df7f42daa81783f

        public decimal DailyPrice { get; set; }

        public string Description { get; set; }
	}
}
