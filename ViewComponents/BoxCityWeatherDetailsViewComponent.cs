using Microsoft.AspNetCore.Mvc;
using WeatherApplication.Factories;
using WeatherApplication.Models;

namespace WeatherApplication.ViewComponents
{
	public class BoxCityWeatherDetailsViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(string? cityCode)
		{
			CityWeatherListFactory listFactory = new CityWeatherListFactory();
			List<CityWeather> cityWeatherList = listFactory.CreatList();
			CityWeather? cityWeather = cityWeatherList.SingleOrDefault(cw => cw.CityUniqueCode == cityCode);
			if (cityWeather == null)
			{
				return View("ErrorPage");
			}
			return View("CityWeatherDetailsBoxDesign", cityWeather);
		}
	}
}
