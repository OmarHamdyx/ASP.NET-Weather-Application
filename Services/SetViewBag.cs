using Interfaces;
using Models;

namespace Services
{
	public class SetViewBag : ISetViewBag
	{
		private readonly ICitiesProvider _citiesProvider;

		public SetViewBag(ICitiesProvider citiesProvider)
		{
			_citiesProvider = citiesProvider;

		}
		public string ReturnTitle(string? cityCode)
		{
			List<CityWeather> cityWeatherList = _citiesProvider.CreatList();
			CityWeather? cityWeather = cityWeatherList.SingleOrDefault(cw => cw.CityUniqueCode == cityCode);

			if (cityWeather == null)
			{
				return "Error!";
			}
			return cityWeather.CityName + " City Weather";
		}
	}
}
