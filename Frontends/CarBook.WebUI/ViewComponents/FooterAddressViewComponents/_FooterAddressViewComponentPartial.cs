using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.FooterAddressViewComponents
{
    public class _FooterAddressViewComponentPartial:ViewComponent
    {
        private readonly IFooterAddressConsumeApiService _footerAddressService;
        private readonly ISharedAuthorizationApiService _shared;
        public _FooterAddressViewComponentPartial(IFooterAddressConsumeApiService footerAddressService, ISharedAuthorizationApiService shared)
        {
            _footerAddressService = footerAddressService;
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _footerAddressService.GetListAsync("FooterAddresses", _shared.AccessToken));
        }
    }
}
