using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class CarPricingConsumeApiService : GenericConsumeApiService<ResultCarPricingDto, CreateCarPricingDto, UpdateCarPricingDto>, ICarPricingConsumeApiServe
    {
        private readonly HttpClient _httpClient;
        private readonly ISharedAuthorizationApiService _shared;
        public CarPricingConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client,shared)
        {
           _httpClient = client;
            _shared = shared;
        }

        public async Task<List<GetCarPricingWithTimePeriodDto>> GetCarPricingWithTimePeriod(string token)
        {
            _shared.TokenHeaderAuthorization(_httpClient, token);
            return await _httpClient.GetFromJsonAsync<List<GetCarPricingWithTimePeriodDto>>("CarPricings/GetCarPricingWithTimePeriod");
        }
    }
}
