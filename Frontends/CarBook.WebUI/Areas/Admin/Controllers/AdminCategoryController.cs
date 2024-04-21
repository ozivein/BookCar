using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class AdminCategoryController : Controller
    {
        private readonly ICategoryConsumeApiService _CategoryConsumeApiService;
        private readonly IDataProtector _dataProtect;
        private readonly ISharedAuthorizationApiService _shared;
        public AdminCategoryController(ICategoryConsumeApiService CategoryConsumeApiService, IDataProtectionProvider dataProtect, ISharedAuthorizationApiService shared)
        {
            _CategoryConsumeApiService = CategoryConsumeApiService;
            _dataProtect = dataProtect.CreateProtector("AdminCategoryController");
            _shared = shared;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _CategoryConsumeApiService.GetListAsync("Categories", _shared.AccessToken);
            values.ForEach(x => x.DataProtect = _dataProtect.Protect(x.CategoryId.ToString()));
            return View(values);
        }

        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var response = await _CategoryConsumeApiService.CreateAsync("Categories", createCategoryDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Update(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            return View(await _CategoryConsumeApiService.GetByIdUpdateAsync("Categories", dataValue, _shared.AccessToken));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateCategoryDto updateCategoryDto)
        {
            var response = await _CategoryConsumeApiService.UpdateAsync("Categories", updateCategoryDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            var response = await _CategoryConsumeApiService.RemoveAsync("Categories", dataValue, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
