using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces
{
    public interface IReservationRepository
    {
        Task<List<Reservation>> GetReservationWithCarAndLocationList();
    }
}
