using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using weatherApplication.Models;

namespace weatherApplication.Controllers
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
        public IActionResult Validation(string username, string password)
        {

            if (password == "Requalificadas" && username== "requalificadas@gmail.com")

            {
                return View("Main");

            }
            else

            {

                string errorMessage = "Dados incorretos. Tente novamente!";
                ViewData["ErrorMessage"] = errorMessage;
                return View("Index");

            }
            

            
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}