using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.AboutViewComponents
{
    public class _AboutUsViewComponentPartial : ViewComponent
    {
        private readonly IAboutConsumeApiService _aboutConsumeApiService;
        private readonly ISharedAuthorizationApiService _shared;
        public _AboutUsViewComponentPartial(IAboutConsumeApiService aboutConsumeApiService, ISharedAuthorizationApiService shared)
        {
            _aboutConsumeApiService = aboutConsumeApiService;
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _aboutConsumeApiService.GetListAsync("Abouts", _shared.AccessToken));
        }
    }
}
