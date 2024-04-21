using UdemyCarBook.Dto.Dtos;

namespace UdemyCarBook.WebUI.Abstracts
{
    public interface IRentACarConsumeApiService
    {
        Task<List<ResultRenACarFilterListDto>> GetRentACarFilter(int locationId, bool available);
    }
}
