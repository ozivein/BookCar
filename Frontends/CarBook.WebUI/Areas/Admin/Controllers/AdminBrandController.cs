using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminBrandController : Controller
    {
        private readonly IBrandConsumeApiService _BrandConsumeApiService;
        private readonly IDataProtector _dataProtect;
        private readonly ISharedAuthorizationApiService _shared;
        public AdminBrandController(IBrandConsumeApiService BrandConsumeApiService, IDataProtectionProvider dataProtect, ISharedAuthorizationApiService shared)
        {
            _BrandConsumeApiService = BrandConsumeApiService;
            _dataProtect = dataProtect.CreateProtector("AdminBrandController");
            _shared = shared;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _BrandConsumeApiService.GetListAsync("Brands",_shared.AccessToken);
            values.ForEach(x => x.DataProtect = _dataProtect.Protect(x.BrandId.ToString()));
            return View(values);
        }

        public IActionResult CreateBrand()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandDto createBrandDto)
        {
            var response = await _BrandConsumeApiService.CreateAsync("Brands", createBrandDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Update(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            return View(await _BrandConsumeApiService.GetByIdUpdateAsync("Brands", dataValue, _shared.AccessToken));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateBrandDto updateBrandDto)
        {
            var response = await _BrandConsumeApiService.UpdateAsync("Brands", updateBrandDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            var response = await _BrandConsumeApiService.RemoveAsync("Brands", dataValue, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
