using System.Text.Json;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.WebUI.Abstracts;
using UdemyCarBook.WebUI.Models;

namespace UdemyCarBook.WebUI.Services
{
    public class AccountConsumeApiService : IAccountConsumeApiService
    {
        private readonly HttpClient _client;

        public AccountConsumeApiService(HttpClient client)
        {
            _client = client;
        }

        public async Task<HttpResponseMessage> CreateAppUserAsync(RegisterDto registerDto)
        {
            return await _client.PostAsJsonAsync<RegisterDto>($"Accounts/CreateAppUser", registerDto);
        }

        public async Task<TokenResponseModel> LoginAsync(LoginDto loginDto)
        {
            var response = await _client.PostAsJsonAsync<LoginDto>($"Accounts", loginDto);
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var tokenModel = JsonSerializer.Deserialize<TokenResponseModel>(jsonData, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });

                return tokenModel;
            }
            return new TokenResponseModel();
        }
    }
}
