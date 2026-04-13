using ApartmentsRentService.Domain.Exceptions;
using ApartmentsRentService.ValueObjects;

namespace ApartmentsRentService.Domain.Entities;

public class Availability
{
    public int Id { get; }
    public int ApartmentId { get; }
    public DateRange DateRange { get; }

    public Availability(int id, int apartmentId, DateRange dateRange)
    {
        if (id <= 0)
            throw new InvalidIdException();
        if (apartmentId <= 0)
            throw new InvalidIdException();
        if (dateRange == null)
            throw new ArgumentNullException(nameof(dateRange));

        Id = id;
        ApartmentId = apartmentId;
        DateRange = dateRange;
    }
}
