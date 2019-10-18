using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using app_web.Models;
using Microsoft.AspNetCore.Authorization;

namespace app_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        public IActionResult Gracias()
        {
            return View();
        }

        [Authorize]
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Contacto(ContactoViewModel contactoViewModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Gracias");
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
