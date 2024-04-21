using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces
{
    public interface ICarRepository
    {
        Task<List<Car>> GetCarWithBrand();
        Task<List<Car>> GetLastFiveCarWithBrand();
    }
}
