using UdemyCarBook.Dto.Dtos;

namespace UdemyCarBook.WebUI.Abstracts
{
    public interface ICarPricingConsumeApiServe : IGenericConsumeApiService<ResultCarPricingDto, CreateCarPricingDto, UpdateCarPricingDto>
    {
        Task<List<GetCarPricingWithTimePeriodDto>> GetCarPricingWithTimePeriod(string token);
    }
}
