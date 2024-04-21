using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.CarDetailViewComponents
{
    public class _CarDetailCommentsByCarIdComponentPartial : ViewComponent
    {
        private readonly IDataProtector _dataProtector;
        private readonly IReviewConsumeApiService _reviewConsumeApiService;
        public _CarDetailCommentsByCarIdComponentPartial(IDataProtectionProvider dataProtector, IReviewConsumeApiService reviewConsumeApiService)
        {
            _dataProtector = dataProtector.CreateProtector("CarController");
            _reviewConsumeApiService = reviewConsumeApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var dataCarId = int.Parse(_dataProtector.Unprotect(id));
            return View(await _reviewConsumeApiService.GetReviewListByCarIdAsync(dataCarId));
        }
    }
}
