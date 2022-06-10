using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tex.Models;

namespace Tex.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult HomeTwo()
        {
            return View();
        }

        public IActionResult Info()
        {
            return View();
        }
        public IActionResult Stet()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}