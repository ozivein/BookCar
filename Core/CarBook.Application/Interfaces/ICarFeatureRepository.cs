using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces
{
    public interface ICarFeatureRepository
    {
        Task<List<CarFeature>> GetCarFeatureByCarId(int CarId);
        Task UpdateCarFeatureAvailableChangeToFalse(int CarFeatureId);
        Task UpdateCarFeatureAvailableChangeToTrue(int CarFeatureId);
    }
}
