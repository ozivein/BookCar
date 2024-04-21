using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class CarDescriptionConsumeApiService : ICarDescriptionConsumeApiService
    {
        private readonly HttpClient _client;

        public CarDescriptionConsumeApiService(HttpClient client)
        {
            _client = client;
        }

        public async Task<ResultCarDescrpitonByCarIdDto> GetCarDescrpitonByCarIdAsync(int carId)
        {
            
            return await _client.GetFromJsonAsync<ResultCarDescrpitonByCarIdDto>($"CarDescriptions/{carId}");
        }
    }
}
