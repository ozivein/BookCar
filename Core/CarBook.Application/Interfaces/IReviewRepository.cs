using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces
{
    public interface IReviewRepository
    {
        Task<List<Review>> GetReviewListByCarIdAsync(int carId);

    }
}
