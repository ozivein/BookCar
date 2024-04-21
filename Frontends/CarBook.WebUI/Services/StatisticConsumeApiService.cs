using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class StatisticConsumeApiService : IStatisticConsumeApiService
    {
        private readonly HttpClient _client;

        public StatisticConsumeApiService(HttpClient client)
        {
            _client = client;
        }

        public async Task<StatisticCountDto> GetStatisticCount(string controllerName, string actionName)
        {
            return await _client.GetFromJsonAsync<StatisticCountDto>($"{controllerName}/{actionName}");
        }
    }
}
