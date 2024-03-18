using Microsoft.AspNetCore.Mvc;
using WeatherApplication.Factories;
using WeatherApplication.StaticClasses;

namespace WeatherApplication.Controllers
{
    [Controller]
    public class AllWeatherDetailsController : Controller
    {
        [Route("/")]
        public IActionResult ReturnAllWeatherDetails()
        {
			return View();
		}
    }
}
