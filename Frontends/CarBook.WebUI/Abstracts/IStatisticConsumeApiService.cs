using UdemyCarBook.Dto.Dtos;

namespace UdemyCarBook.WebUI.Abstracts
{
    public interface IStatisticConsumeApiService
    {
        Task<StatisticCountDto> GetStatisticCount(string controllerName, string actionName);
    }
}
