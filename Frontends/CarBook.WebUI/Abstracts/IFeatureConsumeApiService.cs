using UdemyCarBook.Dto.Dtos;

namespace UdemyCarBook.WebUI.Abstracts
{
    public interface IFeatureConsumeApiService:IGenericConsumeApiService<ResultFeatureDto,CreateFeatureDto,UpdateFeatureDto>
    {
        Task<List<ResultFeatureCarIdListDto>> GetFeatureListAndCarId(string token);
    }
}
