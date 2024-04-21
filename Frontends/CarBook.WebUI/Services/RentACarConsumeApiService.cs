using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class RentACarConsumeApiService : IRentACarConsumeApiService
    {
        private readonly HttpClient _client;

        public RentACarConsumeApiService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<ResultRenACarFilterListDto>> GetRentACarFilter(int locationId, bool available)
        {
            return await _client.GetFromJsonAsync<List<ResultRenACarFilterListDto>>($"RentACars/{locationId}/{available}");
        }
    }
}
