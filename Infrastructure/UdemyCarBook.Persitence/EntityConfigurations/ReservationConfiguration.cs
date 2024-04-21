using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Persitence.EntityConfigurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasOne(x => x.PickUpLocation).WithMany(x => x.PickUpReservations).HasForeignKey(x => x.PickUpLocationId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.DropOffLocation).WithMany(x => x.DropOffReservations).HasForeignKey(x => x.DropOffLocationId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.Car).WithMany(x => x.Reservations).HasForeignKey(x => x.CarId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
