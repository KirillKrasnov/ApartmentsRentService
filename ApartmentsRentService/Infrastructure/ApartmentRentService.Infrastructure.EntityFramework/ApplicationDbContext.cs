using ApartmentsRentService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApartmentsRentService.Infrastructure.EntityFramework;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    public DbSet<Apartment> Apartments { get; set; }

    public DbSet<Availability> Availabilities { get; set; }

    public DbSet<Booking> Bookings { get; set; }

    public DbSet<Landlord> Landlords { get; set; }

    public DbSet<Tenant> Tenants { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

        base.OnModelCreating(modelBuilder);
    }

}