using UdemyCarBook.Dto.Dtos;

namespace UdemyCarBook.WebUI.Abstracts
{
    public interface ICarDescriptionConsumeApiService
    {
        Task<ResultCarDescrpitonByCarIdDto> GetCarDescrpitonByCarIdAsync(int carId);
    }
}
