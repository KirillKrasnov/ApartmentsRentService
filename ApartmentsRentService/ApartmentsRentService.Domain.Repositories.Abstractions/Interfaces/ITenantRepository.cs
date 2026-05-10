using ApartmentsRentService.Domain.Entities;
using ApartmentsRentService.Domain.Repositories.Abstractions.Base;

namespace ApartmentsRentService.Domain.Repositories.Abstractions.Interfaces;

public interface ITenantRepository : IRepository<Tenant, Guid>
{
    Task<Tenant?> GetByEmailAsync(string email, CancellationToken cancellationToken);
}