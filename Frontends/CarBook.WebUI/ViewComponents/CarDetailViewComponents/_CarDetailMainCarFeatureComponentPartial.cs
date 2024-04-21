using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.CarDetailViewComponents
{
    public class _CarDetailMainCarFeatureComponentPartial : ViewComponent
    {
        private readonly ICarConsumeApiService _carConsumeApiService;
        private readonly IDataProtector _dataProtect;
        private readonly ISharedAuthorizationApiService _shared;
        public _CarDetailMainCarFeatureComponentPartial(ICarConsumeApiService carConsumeApiService, IDataProtectionProvider dataProtect, ISharedAuthorizationApiService shared)
        {
            _carConsumeApiService = carConsumeApiService;
            _dataProtect = dataProtect.CreateProtector("CarController");
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));

            return View(await _carConsumeApiService.GetByIdAsync("Cars", dataValue,_shared.AccessToken));
        }
    }
}
