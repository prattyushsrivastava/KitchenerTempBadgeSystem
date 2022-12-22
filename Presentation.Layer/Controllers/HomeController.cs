using Business.Layer.Services;
using Data.Access.Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Presentation.Layer.Models;
using System.Diagnostics;

namespace Presentation.Layer.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeService _empService;
        public HomeController(IEmployeeService empService)
        {
            _empService=empService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult show(string fn, string ln)
        {
            _empService.GetEmp(fn,ln);

            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }
    }
}