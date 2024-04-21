using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]

    public class AdminCarController : Controller
    {
        private readonly ICarConsumeApiService _carConsumerApiService;
        private readonly IDataProtector _dataProtect;
        private readonly IBrandConsumeApiService _brandConsumeApiService;
        private readonly ISharedAuthorizationApiService _shared;
        public AdminCarController(ICarConsumeApiService carConsumerApiService, IDataProtectionProvider dataProtect, IBrandConsumeApiService brandConsumeApiService, ISharedAuthorizationApiService shared)
        {
            _carConsumerApiService = carConsumerApiService;
            _dataProtect = dataProtect.CreateProtector("AdminCarController");
            _brandConsumeApiService = brandConsumeApiService;
            _shared = shared;
        }

        public async Task GetBrandListSelect()
        {
            var brandValues = await _brandConsumeApiService.GetListAsync("Brands", _shared.AccessToken);

            ViewBag.BrandSelectValue = new SelectList(brandValues, "BrandId", "Name");
        }
        public async Task<IActionResult> Index()
        {
            var values = await _carConsumerApiService.GetListAsync("cars", "GetCarWithBrand", _shared.AccessToken);

            values.ForEach(x => x.DataProtect = _dataProtect.Protect(x.CarId.ToString()));
            return View(values);
        }

        public async Task<IActionResult> CreateCar()
        {
            await GetBrandListSelect();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarDto createCarDto)
        {
            var response = await _carConsumerApiService.CreateAsync("Cars", createCarDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Update(string id)
        {

            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            var data = await _carConsumerApiService.GetByIdUpdateAsync("Cars", dataValue, _shared.AccessToken);
            await GetBrandListSelect();
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateCarDto updateCarDto)
        {
            var response = await _carConsumerApiService.UpdateAsync("Cars", updateCarDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            var response = await _carConsumerApiService.RemoveAsync("Cars", dataValue, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

    }
}
