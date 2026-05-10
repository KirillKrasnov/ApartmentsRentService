using ApartmentsRentService.Domain.Entities.Base;
using ApartmentsRentService.Domain.Exceptions;
using ApartmentsRentService.ValueObjects;

namespace ApartmentsRentService.Domain.Entities;

public class Availability : Entity<Guid>
{
    public Apartment Apartment { get; private set; }

    public DateRange DateRange { get; private set; }

    protected Availability()
    {
    }

    protected Availability(
        Guid id,
        Apartment apartment,
        DateRange dateRange)
        : base(id)
    {
        if (id == Guid.Empty)
            throw new InvalidIdException();

        Apartment = apartment
            ?? throw new ArgumentNullException(nameof(apartment));

        DateRange = dateRange
            ?? throw new ArgumentNullException(nameof(dateRange));
    }

    public Availability(Apartment apartment, DateRange dateRange) : base(Guid.NewGuid())
    {
        Apartment = apartment
            ?? throw new ArgumentNullException(nameof(apartment));

        DateRange = dateRange
            ?? throw new ArgumentNullException(nameof(dateRange));
    }

    public void ChangeDateRange(DateRange dateRange)
    {
        DateRange = dateRange
            ?? throw new ArgumentNullException(nameof(dateRange));
    }
}