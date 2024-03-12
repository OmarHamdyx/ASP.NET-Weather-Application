﻿using Microsoft.AspNetCore.Mvc;
using WeatherApplication.Factories;
using WeatherApplication.Models;

namespace WeatherApplication.Controllers
{
    public class CityWeatherDetailsController : Controller
    {
        [Route("/weather/{cityCode}")]
        public IActionResult ReturnCityWeatherDetail(string? cityCode)
        {
            CityWeatherListFactory listFactory = new CityWeatherListFactory();
            List<CityWeather> cityWeatherList = listFactory.CreatList();
            CityWeather? cityWeather = cityWeatherList.SingleOrDefault(cw => cw.CityUniqueCode == cityCode);

            if (cityWeather == null)
            {
                return View("ErrorPage");
            }

            return View(cityWeather);
        }

    }
}
