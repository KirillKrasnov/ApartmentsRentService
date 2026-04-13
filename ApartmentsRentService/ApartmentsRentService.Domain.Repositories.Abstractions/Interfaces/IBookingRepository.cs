using ApartmentsRentService.Domain.Entities;

namespace ApartmentsRentService.Domain.Repositories.Abstractions;

public interface IBookingRepository
{
    Task<Booking?> GetByIdAsync(int id);
    Task AddAsync(Booking booking);
    Task UpdateAsync(Booking booking);
    Task DeleteAsync(int id);
}