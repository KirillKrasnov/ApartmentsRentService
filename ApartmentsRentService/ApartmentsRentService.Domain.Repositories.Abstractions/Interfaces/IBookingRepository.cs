using ApartmentsRentService.Domain.Entities;
using ApartmentsRentService.Domain.Repositories.Abstractions.Base;

namespace ApartmentsRentService.Domain.Repositories.Abstractions.Interfaces;

public interface IBookingRepository : IRepository<Booking, Guid>
{
    Task<IEnumerable<Booking>> GetByTenantIdAsync(Guid tenantId, CancellationToken cancellationToken);

    Task<IEnumerable<Booking>> GetByApartmentIdAsync(Guid apartmentId, CancellationToken cancellationToken);
}