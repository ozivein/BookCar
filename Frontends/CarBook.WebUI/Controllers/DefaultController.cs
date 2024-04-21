using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Json;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ILocationConsumeApiService _locationConsumeApiService;
        private readonly ISharedAuthorizationApiService _shared;
        public DefaultController(ILocationConsumeApiService locationConsumeApiService, ISharedAuthorizationApiService shared)
        {
            _locationConsumeApiService = locationConsumeApiService;
            _shared = shared;
        }

        public async Task GetLocationListSelect()
        {
            var values = await _locationConsumeApiService.GetListAsync("Locations", _shared.AccessToken);

            ViewBag.SelectValues = new SelectList(values, "LocationId", "Name");
        }

        public async Task<IActionResult> Index()
        {
            await GetLocationListSelect();
            return View(new ResultRentAcarLocationFilterDto());
        }
        [HttpPost]
        public IActionResult Index(ResultRentAcarLocationFilterDto resultRentAcarLocationFilter)
        {

            TempData["Result"] = JsonSerializer.Serialize(resultRentAcarLocationFilter);
            return RedirectToAction("Index", "RentACar");

        }
    }
}
