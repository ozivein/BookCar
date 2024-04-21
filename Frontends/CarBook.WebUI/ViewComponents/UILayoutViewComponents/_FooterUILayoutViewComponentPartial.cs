using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _FooterUILayoutViewComponentPartial : ViewComponent
    {
        private readonly IFooterAddressConsumeApiService _footerAddressConsumeApiService;
        private readonly ISharedAuthorizationApiService _shared;
        public _FooterUILayoutViewComponentPartial(IFooterAddressConsumeApiService footerAddressConsumeApiService, ISharedAuthorizationApiService shared)
        {
            _footerAddressConsumeApiService = footerAddressConsumeApiService;
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _footerAddressConsumeApiService.GetListAsync("FooterAddresses", _shared.AccessToken));
        }
    }
}
