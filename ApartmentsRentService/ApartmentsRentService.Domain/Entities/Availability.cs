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

    public Availability(Apartment apartment, DateRange dateRange)
        : this(Guid.NewGuid(), apartment, dateRange)
    {}

    public void ChangeDateRange(Landlord landlord, DateRange dateRange)
    {
        if (landlord == null)
            throw new ArgumentNullException(nameof(landlord));

        if (landlord.Id != Apartment.Landlord.Id)
            throw new LandlordEditAvailabilityException(this, landlord);

        DateRange = dateRange
            ?? throw new ArgumentNullException(nameof(dateRange));
    }
}