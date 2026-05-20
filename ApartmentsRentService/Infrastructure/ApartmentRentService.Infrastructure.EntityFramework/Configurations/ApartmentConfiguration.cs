using ApartmentsRentService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApartmentsRentService.Infrastructure.EntityFramework.Configurations;

public class ApartmentConfiguration : IEntityTypeConfiguration<Apartment>
{
    public void Configure(EntityTypeBuilder<Apartment> builder)
    {
        builder.HasKey(x => x.Id);

        builder.OwnsOne(x => x.Title, title =>
        {
            title.Property(x => x.Value)
                .HasColumnName("Title")
                .HasMaxLength(100)
                .IsRequired();
        });

        builder.OwnsOne(x => x.Description, description =>
        {
            description.Property(x => x.Value)
                .HasColumnName("Description")
                .HasMaxLength(2000)
                .IsRequired();
        });

        builder.OwnsOne(x => x.PricePerNight, money =>
        {
            money.Property(x => x.Value)
                .HasColumnName("PricePerNight")
                .HasColumnType("decimal(18,2)")
                .IsRequired();
        });

        builder.OwnsOne(x => x.Address, address =>
        {
            address.Property(x => x.Value)
                .HasColumnName("Address")
                .HasMaxLength(200)
                .IsRequired();
        });

        builder.HasOne(x => x.Landlord)
            .WithMany()
            .IsRequired();
    }
}