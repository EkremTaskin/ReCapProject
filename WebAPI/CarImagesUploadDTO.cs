using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
	public class CarImagesUploadDTO
	{
		public IFormFile Files { get; set; }

		public int Id { get; set; }

		public int CarId { get; set; }

		public string ImagePath { get; set; }

		public DateTime Date { get; set; }
	}
}
