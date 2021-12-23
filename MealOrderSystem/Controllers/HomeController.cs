using MealOrderSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MealSystem.Models;
namespace MealOrderSystem.Controllers
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

            DataManagement mealData = new DataManagement();
            List<MealData> mealDatas = mealData.GetMealMenu();
            ViewBag.mealDatas = mealDatas;

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