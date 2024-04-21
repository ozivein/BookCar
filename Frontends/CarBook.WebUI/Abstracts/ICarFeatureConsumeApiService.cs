using UdemyCarBook.Dto.Dtos;

namespace UdemyCarBook.WebUI.Abstracts
{
    public interface ICarFeatureConsumeApiService:IGenericConsumeApiService<ResultCarFeatureListByCarIdDto,CreateCarFeatureDto,UpdateCarFeatureDto>
    {
        Task<List<ResultCarFeatureListByCarIdDto>> GetCarFeatureListByCarId(int CarId, string token);
        Task ChangeAvailableFalse(int CarFeatureId, string token);
        Task ChangeAvailableTrue(int CarFeatureId, string token);
    }
}
