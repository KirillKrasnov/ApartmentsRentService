using ApartmentsRentService.Domain.Entities;
using ApartmentsRentService.Domain.Repositories.Abstractions.Base;

namespace ApartmentsRentService.Domain.Repositories.Abstractions;

public interface IApartmentRepository : IRepository<Apartment, Guid>
{
    Task<IEnumerable<Apartment>> GetAvailableApartmentsAsync(CancellationToken cancellationToken);

    Task<IEnumerable<Apartment>> GetByCityAsync(string city, CancellationToken cancellationToken);
}