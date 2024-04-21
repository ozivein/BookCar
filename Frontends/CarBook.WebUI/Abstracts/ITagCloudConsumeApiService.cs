using UdemyCarBook.Dto.Dtos;

namespace UdemyCarBook.WebUI.Abstracts
{
    public interface ITagCloudConsumeApiService:IGenericConsumeApiService<ResultTagCloudDto,CreateTagCloudDto,UpdateTagCloudDto>
    {
        Task<List<GetTagCloudByBlogIdDto>> GetTagCloudByBlogIdListAsync(int id, string token);
    }
}
