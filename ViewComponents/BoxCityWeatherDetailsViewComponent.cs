using Microsoft.AspNetCore.Mvc;
using WeatherApplication.Factories;
using WeatherApplication.Models;

namespace WeatherApplication.ViewComponents
{
	public class BoxCityWeatherDetailsViewComponent : ViewComponent
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
		public async Task<IViewComponentResult> InvokeAsync(string? cityCode)
		{
			List<CityWeather> cityWeatherList = CityWeatherListFactory.CreatList();
			CityWeather? cityWeather = cityWeatherList.SingleOrDefault(cw => cw.CityUniqueCode == cityCode);

			if (cityWeather == null)
			{
				return View("ErrorPage");
			}

			ViewBag.CssClass = ReturnBoxColor(cityWeather.TemperatureFahrenheit);

			return View("CityWeatherDetailsBoxDesign", cityWeather);
		}
	}
}
