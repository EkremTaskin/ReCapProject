using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ImagesController : ControllerBase
	{
		IImageService _imageService;
		IWebHostEnvironment _webHostEnvironment;
		public ImagesController(IImageService imageService, IWebHostEnvironment webHostEnvironment)
		{
			_imageService = imageService;
			_webHostEnvironment = webHostEnvironment;
		}

		[HttpPost("add")]
		public IActionResult Add([FromForm] CarImagesUploadDTO objectFile)
		{
			try
			{
				if (objectFile.Files.Length > 0)
				{
					string path = _webHostEnvironment.WebRootPath + "\\Upload\\";

					if (!Directory.Exists(path))
					{
						Directory.CreateDirectory(path);
					}
					var DosyaUzantisi = Path.GetExtension(objectFile.Files.FileName);
					using (FileStream fileStream = System.IO.File.Create(path + Guid.NewGuid().ToString("D") + DosyaUzantisi))
					{
						objectFile.Files.CopyTo(fileStream);
						fileStream.Flush();
						return Ok("Uploaded");
					}
				}
			}
			catch (Exception)
			{

				throw;
			}
			return BadRequest("Eklenmedi");
		}
	}
}
