using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.TestimonialViewComponents
{
    public class _TestimonialViewComponentPartial : ViewComponent
    {
        private readonly ITestimonialConsumeApiService _testimonialService;
        private readonly ISharedAuthorizationApiService _shared;
        public _TestimonialViewComponentPartial(ITestimonialConsumeApiService testimonialService, ISharedAuthorizationApiService shared)
        {
            _testimonialService = testimonialService;
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _testimonialService.GetListAsync("Testimonials", _shared.AccessToken));
        }
    }
}
