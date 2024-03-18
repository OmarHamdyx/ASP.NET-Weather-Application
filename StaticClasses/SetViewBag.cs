using WeatherApplication.Factories;
using WeatherApplication.Models;

namespace WeatherApplication.StaticClasses
{
	public static class SetViewBag
	{
		public static string ReturnTitleString(string? cityCode)
		{
			CityWeatherListFactory listFactory = new CityWeatherListFactory();
			List<CityWeather> cityWeatherList = listFactory.CreatList();
			CityWeather? cityWeather = cityWeatherList.SingleOrDefault(cw => cw.CityUniqueCode == cityCode);

			if (cityWeather == null)
			{
				return "Error!";
			}
			return cityWeather.CityName + " City Weather";
		}
	}
}
