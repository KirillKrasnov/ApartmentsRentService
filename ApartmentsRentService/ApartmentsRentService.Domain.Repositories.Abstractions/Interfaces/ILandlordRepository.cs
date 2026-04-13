using ApartmentsRentService.Domain.Entities;

namespace ApartmentsRentService.Domain.Repositories.Abstractions;

public interface ILandlordRepository
{
    Task<Landlord?> GetByIdAsync(int id);
    Task AddAsync(Landlord landlord);
    Task UpdateAsync(Landlord landlord);
    Task DeleteAsync(int id);
}