using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace WeatherApplication.Controllers
{
    [Controller]
    public class CityWeatherDetailsController : Controller
    {
        private readonly ISetViewBag _setViewBag;

		public CityWeatherDetailsController(ISetViewBag setViewBag) 
        {
			_setViewBag = setViewBag;
		}
        [Route("/weather/{cityCode}")]
        public IActionResult ReturnCityWeatherDetails(string? cityCode)
        {
            ViewBag.Title = _setViewBag;
			return View(null,cityCode);
        }

    }
}
