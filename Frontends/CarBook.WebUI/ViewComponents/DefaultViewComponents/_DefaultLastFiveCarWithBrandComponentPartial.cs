using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultLastFiveCarWithBrandComponentPartial : ViewComponent
    {
        private readonly ICarConsumeApiService _carConsumeService;
        private readonly IDataProtector _dataProtector;
        public _DefaultLastFiveCarWithBrandComponentPartial(ICarConsumeApiService carConsumeService, IDataProtectionProvider dataProtector)
        {
            _carConsumeService = carConsumeService;
            _dataProtector = dataProtector.CreateProtector("CarController");
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
           var values= await _carConsumeService.GetListAsync("Cars", "GetLastFiveCarWithBrand");
            values.ForEach(x => x.DataProtect = _dataProtector.Protect(x.CarId.ToString()));
            return View(values);
        }
    }
}
