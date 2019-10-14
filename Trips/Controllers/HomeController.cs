using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Trips.DTO.Repository;

namespace Trips.Controllers
{
    public class HomeController : Controller
    {
        /* private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */
        private readonly ICityRepository _cityRepository;

        public HomeController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        private void SetCityViewBag(int? CityId = null)
        {
            ViewBag.City = CityId == null
                ? new SelectList(_cityRepository.GetCities(),
                    "Id",
                    "Name")
                : new SelectList(_cityRepository.GetCities(),
                    "Id",
                    "Name",
                    CityId);
        }

        public IActionResult Index()
        {
            //SetCityViewBag();
            ViewBag.Cities = new SelectList(_cityRepository.GetCities(), "Id", "Name");
            return View();
        }
    }
}
