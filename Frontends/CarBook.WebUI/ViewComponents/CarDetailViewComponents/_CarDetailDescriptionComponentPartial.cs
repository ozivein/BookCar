using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.CarDetailViewComponents
{
    public class _CarDetailDescriptionComponentPartial : ViewComponent
    {
        private readonly ICarDescriptionConsumeApiService _service;
        private readonly IDataProtector _dataProtector;
        public _CarDetailDescriptionComponentPartial(ICarDescriptionConsumeApiService service, IDataProtectionProvider dataProtector)
        {
            _service = service;
            _dataProtector = dataProtector.CreateProtector("CarController");
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var dataCarId = int.Parse(_dataProtector.Unprotect(id));
            return View(await _service.GetCarDescrpitonByCarIdAsync(dataCarId));
        }
    }
}
