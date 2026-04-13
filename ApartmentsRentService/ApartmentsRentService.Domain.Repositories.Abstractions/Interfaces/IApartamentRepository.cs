using ApartmentsRentService.Domain.Entities;

namespace ApartmentsRentService.Domain.Repositories.Abstractions;

public interface IApartmentRepository
{
    Task<Apartment?> GetByIdAsync(int id);
    Task AddAsync(Apartment apartment);
    Task UpdateAsync(Apartment apartment);
    Task DeleteAsync(int id);
}