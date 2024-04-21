using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.ServiceViewComponents
{
    public class _ServiceComponentPartial : ViewComponent
    {
        private readonly IServiceConsumeApiService _serviceConsumeApi;
        private readonly ISharedAuthorizationApiService _shared;
        public _ServiceComponentPartial(IServiceConsumeApiService serviceConsumeApi, ISharedAuthorizationApiService shared)
        {
            _serviceConsumeApi = serviceConsumeApi;
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _serviceConsumeApi.GetListAsync("Services", _shared.AccessToken));
        }
    }
}
