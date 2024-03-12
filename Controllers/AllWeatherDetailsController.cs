using Microsoft.AspNetCore.Mvc;
using WeatherApplication.Factories;

namespace WeatherApplication.Controllers
{
    public class AllWeatherDetailsController : Controller
    {
        [Route("/")]
        public IActionResult ReturnAllWeatherDetails()
        {
            CityWeatherListFactory listFactory = new CityWeatherListFactory();
            return View(listFactory.CreatList());
        }
    }
}
