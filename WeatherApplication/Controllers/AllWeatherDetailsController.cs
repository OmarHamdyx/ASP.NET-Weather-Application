using Microsoft.AspNetCore.Mvc;


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
