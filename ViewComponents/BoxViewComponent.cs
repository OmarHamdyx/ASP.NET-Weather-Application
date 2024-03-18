using Microsoft.AspNetCore.Mvc;
using WeatherApplication.Models;

namespace WeatherApplication.ViewComponents
{
	public class BoxViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(CityWeather cityWeather)
		{
			return View("DefaultBoxDesign", cityWeather);	
		}
	}
}
