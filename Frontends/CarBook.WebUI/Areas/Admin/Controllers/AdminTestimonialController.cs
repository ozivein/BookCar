using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminTestimonialController : Controller
    {
        private readonly ITestimonialConsumeApiService _TestimonialConsumeApiService;
        private readonly IDataProtector _dataProtect;
        private readonly ISharedAuthorizationApiService _shared;
        public AdminTestimonialController(ITestimonialConsumeApiService TestimonialConsumeApiService, IDataProtectionProvider dataProtect, ISharedAuthorizationApiService shared)
        {
            _TestimonialConsumeApiService = TestimonialConsumeApiService;
            _dataProtect = dataProtect.CreateProtector("AdminTestimonialController");
            _shared = shared;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _TestimonialConsumeApiService.GetListAsync("Testimonials", _shared.AccessToken);
            values.ForEach(x => x.DataProtect = _dataProtect.Protect(x.TestimonialId.ToString()));
            return View(values);
        }

        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            var response = await _TestimonialConsumeApiService.CreateAsync("Testimonials", createTestimonialDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Update(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            return View(await _TestimonialConsumeApiService.GetByIdUpdateAsync("Testimonials", dataValue, _shared.AccessToken));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateTestimonialDto updateTestimonialDto)
        {
            var response = await _TestimonialConsumeApiService.UpdateAsync("Testimonials", updateTestimonialDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            var response = await _TestimonialConsumeApiService.RemoveAsync("Testimonials", dataValue, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
