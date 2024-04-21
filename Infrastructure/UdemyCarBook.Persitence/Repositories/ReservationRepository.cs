using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persitence.Context;

namespace UdemyCarBook.Persitence.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly CarBookContext _context;

        public ReservationRepository(CarBookContext context)
        {
            _context = context;
        }


        public async Task<List<Reservation>> GetReservationWithCarAndLocationList()
        {
            return await _context.Reservations.Include(x => x.Car).Include(x => x.PickUpLocation).Include(x => x.DropOffLocation).ToListAsync();
        }
    }
}
