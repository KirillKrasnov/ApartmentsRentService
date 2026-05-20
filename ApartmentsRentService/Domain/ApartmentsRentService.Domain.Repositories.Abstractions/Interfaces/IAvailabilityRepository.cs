using ApartmentsRentService.Domain.Entities;
using ApartmentsRentService.Domain.Repositories.Abstractions.Base;

namespace ApartmentsRentService.Domain.Repositories.Abstractions.Interfaces;

public interface IAvailabilityRepository : IRepository<Availability, Guid>
{
}