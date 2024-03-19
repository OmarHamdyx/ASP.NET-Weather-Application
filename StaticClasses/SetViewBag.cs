using WeatherApplication.Factories;
using WeatherApplication.Models;

namespace WeatherApplication.StaticClasses
{
	public class SetViewBag
	{
		public static string ReturnTitle(string? cityCode)
		{
			List<CityWeather> cityWeatherList = CityWeatherListFactory.CreatList();
			CityWeather? cityWeather = cityWeatherList.SingleOrDefault(cw => cw.CityUniqueCode == cityCode);

			if (cityWeather == null)
			{
				return "Error!";
			}
			return cityWeather.CityName + " City Weather";
		}
	}
}
