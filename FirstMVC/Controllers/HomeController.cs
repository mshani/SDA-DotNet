using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstMVC.Controllers
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
            var list = new List<Person>();
            list.Add(new Person { Name = "John", Surname = "Smith" , Age = 25, Gender = 'M'});
            list.Add(new Person { Name = "Jane", Surname = "Doe", Age = 21, Gender = 'F' });
            list.Add(new Person { Name = "Anna", Surname = "Johnson", Age = 24, Gender = 'F' });
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Details(Person person)
        {
            return View(person);
        }

        public IActionResult Edit(Person person)
        {
            return View(person);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}