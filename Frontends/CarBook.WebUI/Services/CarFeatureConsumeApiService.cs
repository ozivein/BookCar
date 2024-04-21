using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class CarFeatureConsumeApiService : GenericConsumeApiService<ResultCarFeatureListByCarIdDto, CreateCarFeatureDto, UpdateCarFeatureDto>, ICarFeatureConsumeApiService
    {
        private readonly HttpClient _client;
        private readonly ISharedAuthorizationApiService _shared;
        public CarFeatureConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client, shared)
        {
            _client = client;
            _shared = shared;
        }

        public async Task ChangeAvailableFalse(int CarFeatureId, string token)
        {
            _shared.TokenHeaderAuthorization(_client, token);
            await _client.GetAsync($"CarFeatures/ChangeCarFeatureAvailableFalse/{CarFeatureId}");
        }

        public async Task ChangeAvailableTrue(int CarFeatureId, string token)
        {
            _shared.TokenHeaderAuthorization(_client, token);

            await _client.GetAsync($"CarFeatures/ChangeCarFeatureAvailableTrue/{CarFeatureId}");
        }

        public async Task<List<ResultCarFeatureListByCarIdDto>> GetCarFeatureListByCarId(int CarId, string token)
        {
            _shared.TokenHeaderAuthorization(_client, token);

            return await _client.GetFromJsonAsync<List<ResultCarFeatureListByCarIdDto>>($"CarFeatures/{CarId}");
        }
    }
}
