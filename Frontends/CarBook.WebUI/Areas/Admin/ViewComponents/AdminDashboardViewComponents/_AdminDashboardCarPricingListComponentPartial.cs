using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Areas.Admin.ViewComponents.AdminDashboardViewComponents
{
    public class _AdminDashboardCarPricingListComponentPartial : ViewComponent
    {
        private readonly ICarPricingConsumeApiServe _carPricingConsumeApiServe;
        private readonly ISharedAuthorizationApiService _shared;
        public _AdminDashboardCarPricingListComponentPartial(ICarPricingConsumeApiServe carPricingConsumeApiServe, ISharedAuthorizationApiService shared)
        {
            _carPricingConsumeApiServe = carPricingConsumeApiServe;
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View(await _carPricingConsumeApiServe.GetCarPricingWithTimePeriod(_shared.AccessToken));
        }
    }
}
