using ApartmentsRentService.Domain.Entities;

namespace ApartmentsRentService.Domain.Repositories.Abstractions;

public interface ITenantRepository
{
    Task<Tenant?> GetByIdAsync(int id);
    Task AddAsync(Tenant tenant);
    Task UpdateAsync(Tenant tenant);
    Task DeleteAsync(int id);
}