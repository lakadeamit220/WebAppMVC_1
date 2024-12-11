using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMVC_1.Models;

namespace WebAppMVC_1.Controllers
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

        public IActionResult Product()
        {
            // Hardcoded list of 5 products
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 75000, Description = "High-performance laptop" },
                new Product { Id = 2, Name = "Smartphone", Price = 25000, Description = "Latest Android smartphone" },
                new Product { Id = 3, Name = "Headphones", Price = 3000, Description = "Noise-canceling headphones" },
                new Product { Id = 4, Name = "Monitor", Price = 15000, Description = "4K Ultra HD monitor" },
                new Product { Id = 5, Name = "Keyboard", Price = 2000, Description = "Mechanical keyboard" }
            };

            // Pass the product list to the view
            return View(products);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Detail()
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
    }
}
