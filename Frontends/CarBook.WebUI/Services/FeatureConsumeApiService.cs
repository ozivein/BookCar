using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class FeatureConsumeApiService : GenericConsumeApiService<ResultFeatureDto, CreateFeatureDto, UpdateFeatureDto>, IFeatureConsumeApiService
    {
        private readonly HttpClient _httpClient;
        private readonly ISharedAuthorizationApiService _shared;
        public FeatureConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client, shared)
        {
            _httpClient = client;
            _shared = shared;
        }

        public async Task<List<ResultFeatureCarIdListDto>> GetFeatureListAndCarId(string token)
        {
            _shared.TokenHeaderAuthorization(_httpClient,token);
            return await _httpClient.GetFromJsonAsync<List<ResultFeatureCarIdListDto>>("Features");
        }
    }
}
