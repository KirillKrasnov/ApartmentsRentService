using ApartmentsRentService.Domain.Entities;
using ApartmentsRentService.Domain.Repositories.Abstractions.Base;

namespace ApartmentsRentService.Domain.Repositories.Abstractions.Interfaces;

public interface ILandlordRepository : IRepository<Landlord, Guid>
{
    Task<Landlord?> GetByEmailAsync(string email, CancellationToken cancellationToken);
}