using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Persitence.EntityConfigurations
{
    public class RenACarProcessConfiguration : IEntityTypeConfiguration<RentACarProcess>
    {
        public void Configure(EntityTypeBuilder<RentACarProcess> builder)
        {
            builder.Property(x => x.PicUpDate).HasColumnType("Date");
            builder.Property(x => x.DropOffDate).HasColumnType("Date");
            builder.Property(x => x.PicUpTime).HasColumnType("Time");
            builder.Property(x => x.DropOffTime).HasColumnType("Time");
        }
    }
}
