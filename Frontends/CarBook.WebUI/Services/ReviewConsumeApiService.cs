using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class ReviewConsumeApiService : IReviewConsumeApiService
    {
        private readonly HttpClient _httpClient;

        public ReviewConsumeApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultReviewListByCarIdDto>> GetReviewListByCarIdAsync(int carId)
        {
            return await _httpClient.GetFromJsonAsync<List<ResultReviewListByCarIdDto>>($"Reviews/{carId}");
        }
    }
}
