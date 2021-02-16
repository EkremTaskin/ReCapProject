using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RentalsController : ServicesController<IRentalService,Rental>
	{
		IRentalService _rentalService;

		public RentalsController(IRentalService rentalService):base(rentalService)
		{
			_rentalService = rentalService;
		}
	}
}
