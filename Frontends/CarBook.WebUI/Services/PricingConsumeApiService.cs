using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class PricingConsumeApiService : GenericConsumeApiService<ResultPricingDto, CreatePricingDto, UpdatePricingDto>, IPricingConsumeApiService
    {
        public PricingConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client, shared)
        {
        }
    }
}
