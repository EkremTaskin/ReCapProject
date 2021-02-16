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
	public class CustomersController : ServicesController<ICustomerService,Customer>
	{
		ICustomerService _customerService;

		public CustomersController(ICustomerService customerService):base(customerService)
		{
			_customerService = customerService;
		}
	}
}
