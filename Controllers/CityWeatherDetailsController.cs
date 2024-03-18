using Microsoft.AspNetCore.Mvc;
using WeatherApplication.Factories;
using WeatherApplication.Models;
using WeatherApplication.StaticClasses;

namespace WeatherApplication.Controllers
{
    [Controller]
    public class CityWeatherDetailsController : Controller
    {
        [Route("/weather/{cityCode}")]
        public IActionResult ReturnCityWeatherDetails(string? cityCode)
        {
            ViewBag.Title= SetViewBag.ReturnTitleString(cityCode);
			return View(null,cityCode);
        }

    }
}
