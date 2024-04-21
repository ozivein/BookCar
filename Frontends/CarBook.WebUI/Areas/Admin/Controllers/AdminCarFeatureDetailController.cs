using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminCarFeatureDetailController : Controller
    {
        private readonly IDataProtector _dataProtect;
        private readonly ICarFeatureConsumeApiService _carFeatureConsumeApiService;
        private readonly IFeatureConsumeApiService _featureConsumeApiService;
        private readonly ISharedAuthorizationApiService _shared;
        public AdminCarFeatureDetailController(IDataProtectionProvider dataProtect, ICarFeatureConsumeApiService carFeatureConsumeApiService, IFeatureConsumeApiService featureConsumeApiService, ISharedAuthorizationApiService shared)
        {
            _dataProtect = dataProtect.CreateProtector("AdminCarController");
            _carFeatureConsumeApiService = carFeatureConsumeApiService;
            _featureConsumeApiService = featureConsumeApiService;
            _shared = shared;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            var values = await _carFeatureConsumeApiService.GetCarFeatureListByCarId(dataValue,_shared.AccessToken);
            values.ForEach(x => x.DataProtect = id);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> Index(List<ResultCarFeatureListByCarIdDto> resultCarFeatureListByCarIdDtos)
        {
            string dataProtect = null;
            foreach (var item in resultCarFeatureListByCarIdDtos)
            {
                dataProtect = item.DataProtect;
                if (item.Available)
                    await _carFeatureConsumeApiService.ChangeAvailableTrue(item.CarFeatureId, _shared.AccessToken);
                else
                    await _carFeatureConsumeApiService.ChangeAvailableFalse(item.CarFeatureId, _shared.AccessToken);

            }
            return RedirectToAction(nameof(Index), new { id = dataProtect.ToString() });
        }

        [HttpGet]
        public async Task<IActionResult> CreateCarFeatureByCarId(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            var values = await _featureConsumeApiService.GetFeatureListAndCarId(_shared.AccessToken);
            values.ForEach(x => x.CarId = dataValue);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCarFeatureByCarId(List<ResultFeatureCarIdListDto> resultFeatureCarIdListDtos)
        {
            string dataProtectCarId = null;
            foreach (var item in resultFeatureCarIdListDtos)
            {
                if (item.Available)
                {
                    CreateCarFeatureDto createCarFeatureDto = new() { CarId = item.CarId, Available = item.Available, FeatureId = item.FeatureId };
                    await _carFeatureConsumeApiService.CreateAsync("CarFeatures", createCarFeatureDto, _shared.AccessToken);
                }
                dataProtectCarId = _dataProtect.Protect(item.CarId.ToString());
            }

            return RedirectToAction(nameof(CreateCarFeatureByCarId), new { id = dataProtectCarId.ToString() });
        }
    }
}
