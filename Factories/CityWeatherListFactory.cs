using WeatherApplication.Models;

namespace WeatherApplication.Factories
{
    public class CityWeatherListFactory
    {

        public static List<CityWeather> CreatList()
        {
            return new List<CityWeather>() {
                new CityWeather{ CityUniqueCode = "LDN", CityName = "London", DateAndTime = DateTime.Parse("2020-12-30 6:00 AM"), TemperatureFahrenheit = 33 },
                new CityWeather{ CityUniqueCode = "NYC", CityName = "New York", DateAndTime = DateTime.Parse("2022-4-13 5:00 PM"), TemperatureFahrenheit = 60 },
                new CityWeather{ CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = DateTime.Parse("2019-06-1 7:00 AM"), TemperatureFahrenheit = 82 },
                new CityWeather{ CityUniqueCode = "ALEX", CityName = "Alexandria", DateAndTime = DateTime.Parse("2018-10-30 5:00 PM"), TemperatureFahrenheit = 69 }
            };
        }
    }
}
