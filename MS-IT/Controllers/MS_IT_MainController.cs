using Microsoft.AspNetCore.Mvc;
using MS_IT.Models;

namespace MS_IT.Controllers
{
    
    public class MS_IT_MainController : Controller
    {
        private static List<CityName> cityNames = new List<CityName>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult UeberMichView()
        {
            return View();
        }

        public IActionResult WeatherInsertView()
        {
            CityName cityName = new CityName();
            return View(cityName);
        }

        public IActionResult WeatherShowResultView(CityName cityName)
        {
            return View(cityName);
        }

        public IActionResult CallWeatherApi()
        {
            return View();
        }
    }
}
