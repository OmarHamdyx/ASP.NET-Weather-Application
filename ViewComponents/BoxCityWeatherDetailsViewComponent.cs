using Microsoft.AspNetCore.Mvc;
using Models;
using Interfaces;

namespace WeatherApplication.ViewComponents
{
	public class BoxCityWeatherDetailsViewComponent : ViewComponent
	{
		private readonly ICitiesProvider _citiesProvider;

		public BoxCityWeatherDetailsViewComponent(ICitiesProvider citiesProvider)
		{
			_citiesProvider = citiesProvider;

		}

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
			List<CityWeather> cityWeatherList = _citiesProvider.CreatList();

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
