using ApartmentsRentService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApartmentsRentService.Infrastructure.EntityFramework.Configurations;

public class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Apartment)
            .WithMany()
            .IsRequired();

        builder.HasOne(x => x.Tenant)
            .WithMany()
            .IsRequired();

        builder.OwnsOne(x => x.DateRange, range =>
        {
            range.Property(x => x.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();

            range.Property(x => x.EndDate)
                .HasColumnName("EndDate")
                .IsRequired();
        });

        builder.Property(x => x.Status)
            .IsRequired();
    }
}