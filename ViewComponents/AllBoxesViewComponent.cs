using Microsoft.AspNetCore.Mvc;
using WeatherApplication.Factories;

namespace WeatherApplication.ViewComponents
{
    [ViewComponent]
    public class AllBoxesViewComponent: ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
			
			return  View("AllBoxesPartialView", CityWeatherListFactory.CreatList());
		}
    }
}
