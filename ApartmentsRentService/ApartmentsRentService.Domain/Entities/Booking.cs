using ApartmentsRentService.Domain.Entities.Base;
using ApartmentsRentService.Domain.Enums;
using ApartmentsRentService.Domain.Exceptions;
using ApartmentsRentService.ValueObjects;

namespace ApartmentsRentService.Domain.Entities;

public class Booking : Entity<Guid>
{
    public Apartment Apartment { get; private set; }

    public Tenant Tenant { get; private set; }

    public DateRange DateRange { get; private set; }

    public BookingStatus Status { get; private set; }

    protected Booking()
    {
    }

    protected Booking(
        Guid id,
        Apartment apartment,
        Tenant tenant,
        DateRange dateRange,
        BookingStatus status)
        : base(id)
    {
        if (id == Guid.Empty)
            throw new InvalidIdException();

        Apartment = apartment
            ?? throw new ArgumentNullException(nameof(apartment));

        Tenant = tenant
            ?? throw new ArgumentNullException(nameof(tenant));

        DateRange = dateRange
            ?? throw new ArgumentNullException(nameof(dateRange));

        Status = status;
    }

    public Booking(Apartment apartment, Tenant tenant, DateRange dateRange, BookingStatus status)
            : this(Guid.NewGuid(), apartment, tenant, dateRange, status)
    {}

    internal void SetStatus(BookingStatus status)
    {
        Status = status;
    }
}