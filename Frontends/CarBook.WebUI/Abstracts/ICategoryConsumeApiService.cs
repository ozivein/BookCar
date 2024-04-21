using UdemyCarBook.Dto.Dtos;

namespace UdemyCarBook.WebUI.Abstracts
{
    public interface ICategoryConsumeApiService : IGenericConsumeApiService<ResultCategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
    }
}
