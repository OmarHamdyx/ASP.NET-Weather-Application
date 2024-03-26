using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Services;
namespace WeatherApplication.ViewComponents
{
    [ViewComponent]
    public class AllBoxesViewComponent: ViewComponent
    {
        private readonly ICitiesProvider _citiesProvider;

		public AllBoxesViewComponent(ICitiesProvider citiesProvider)
        {
			_citiesProvider = citiesProvider;

		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			

			return  View("AllBoxesPartialView", _citiesProvider.CreatList());
		}
    }
}
