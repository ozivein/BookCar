using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces
{
    public interface ICarDescriptionRepository
    {
        Task<CarDescription> GetCarDescrpitonByCarIdAsync(int carId);
    }
}
