using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.DefaultViewComponents
{
    public class _MainCoverDefaultViewComponentPartial : ViewComponent
    {
        private readonly IBannerConsumeApiService _bannerConsumeService;
        private readonly ISharedAuthorizationApiService _shared;
        public _MainCoverDefaultViewComponentPartial(IBannerConsumeApiService bannerConsumeService, ISharedAuthorizationApiService shared)
        {
            _bannerConsumeService = bannerConsumeService;
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _bannerConsumeService.GetListAsync("Banners",_shared.AccessToken));
        }
    }
}
