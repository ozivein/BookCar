using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.CarDetailViewComponents
{
    public class _CarDetailCarFeatureByCarIdComponentPartial : ViewComponent
    {
        private readonly ICarFeatureConsumeApiService _service;
        private readonly IDataProtector _dataProtector;
        private readonly ISharedAuthorizationApiService _shared;
        public _CarDetailCarFeatureByCarIdComponentPartial(ICarFeatureConsumeApiService service, IDataProtectionProvider dataProtector, ISharedAuthorizationApiService shared)
        {
            _service = service;
            _dataProtector = dataProtector.CreateProtector("CarController");
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var dataValue = int.Parse(_dataProtector.Unprotect(id));
            var value = await _service.GetCarFeatureListByCarId(dataValue,_shared.AccessToken);
            if (value is not null)
            {
                return View(value);

            }
            return View(id);

        }
    }
}
