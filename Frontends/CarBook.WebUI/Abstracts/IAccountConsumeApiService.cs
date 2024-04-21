using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.WebUI.Models;

namespace UdemyCarBook.WebUI.Abstracts
{
    public interface IAccountConsumeApiService
    {
        Task<HttpResponseMessage> CreateAppUserAsync(RegisterDto registerDto);
        Task<TokenResponseModel> LoginAsync(LoginDto loginDto);
    }
}
