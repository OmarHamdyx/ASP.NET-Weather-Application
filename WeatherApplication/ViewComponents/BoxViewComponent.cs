using Microsoft.AspNetCore.Mvc;
using Models;

namespace WeatherApplication.ViewComponents
{
	public class BoxViewComponent : ViewComponent
	{

		private string ReturnBoxColor(int? temperature)
		{
			return temperature switch
			{
				(< 44) => "box-blue",
				(>= 44) and (< 74) => "box-green",
				(>= 74) => "box-orange",
				(null) => "box-blue"
			};
		}
		public async Task<IViewComponentResult> InvokeAsync(CityWeather cityWeather)
		{
			ViewBag.CssClass = ReturnBoxColor(cityWeather.TemperatureFahrenheit);
			return View("DefaultBoxDesign", cityWeather);	
		}
	}
}
