using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalPrject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace FinalPrject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _images;
        public HomeController(IHostingEnvironment imag)
        {
            _images = imag;
        }
       public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Course(IFormFile image)
        {
            if (image != null)
            {
                var filename = Path.Combine(_images.WebRootPath, Path.GetFileName(image.FileName));
                image.CopyTo(new FileStream(filename, FileMode.Create));
                ViewData["fileLocation"] = "/" + Path.GetFileName(image.FileName);
            }
            return View();
        }
    }
}
