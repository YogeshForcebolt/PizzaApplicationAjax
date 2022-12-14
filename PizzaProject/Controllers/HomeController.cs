using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaProject.Controllers
{
    
    public class HomeController : Controller
    {
        private DataBaseServices dataBaseService = new DataBaseServices();
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

        public Dictionary<string, int> GetPizzaSize() {
            return dataBaseService.pizzaSize;
        }

        public Dictionary<string, int> GetPizzaTopping()
        {
            return dataBaseService.pizzaTopping;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
