using UdemyCarBook.Dto.Dtos;

namespace UdemyCarBook.WebUI.Abstracts
{
    public interface IReviewConsumeApiService
    {
        Task<List<ResultReviewListByCarIdDto>> GetReviewListByCarIdAsync(int carId);
    }
}
