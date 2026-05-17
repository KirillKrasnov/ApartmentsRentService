using ApartmentsRentService.Domain.Entities.Base;
using ApartmentsRentService.Domain.Enums;
using ApartmentsRentService.Domain.Exceptions;
using ApartmentsRentService.ValueObjects;

namespace ApartmentsRentService.Domain.Entities;

public class Landlord : Entity<Guid>
{
    public PersonName Name { get; private set; }

    public Email Email { get; private set; }

    protected Landlord()
    {
    }

    protected Landlord(
        Guid id,
        PersonName name,
        Email email)
        : base(id)
    {
        if (id == Guid.Empty)
            throw new InvalidIdException();

        Name = name
            ?? throw new ArgumentNullException(nameof(name));

        Email = email
            ?? throw new ArgumentNullException(nameof(email));
    }

    public Landlord(PersonName name, Email email) 
        : this(Guid.NewGuid(), name, email) { }

    public void ChangeName(PersonName name)
    {
        Name = name
            ?? throw new ArgumentNullException(nameof(name));
    }

    public void ChangeEmail(Email email)
    {
        Email = email
            ?? throw new ArgumentNullException(nameof(email));
    }

    public void ApproveBooking(Booking booking)
    {
        if (booking is null)
            throw new ArgumentNullException(nameof(booking));

        if (booking.Apartment.Landlord.Id != Id)
            throw new LandlordApproveBookingException(
                booking,
                this);

        if (booking.Status != BookingStatus.Pending)
            throw new BookingCannotBeApprovedException(booking);

        booking.SetStatus(BookingStatus.Approved);
    }

    public void RejectBooking(Booking booking)
    {
        if (booking is null)
            throw new ArgumentNullException(nameof(booking));

        if (booking.Apartment.Landlord.Id != Id)
            throw new LandlordRejectBookingException(booking, this);

        if (booking.Status != BookingStatus.Pending)
            throw new BookingCannotBeRejectedException(booking);

        booking.SetStatus(BookingStatus.Rejected);
    }

    public void CancelBooking(Booking booking)
    {
        if (booking is null)
            throw new ArgumentNullException(nameof(booking));

        if (booking.Apartment.Landlord.Id != Id)
            throw new LandlordCancelBookingException(
                booking,
                this);

        if (booking.Status == BookingStatus.Cancelled)
            throw new BookingAlreadyCancelledException(
                booking);

        if (booking.Status == BookingStatus.Rejected)
            throw new BookingCannotBeCancelledException(
                booking);

        booking.SetStatus(BookingStatus.Cancelled);
    }
}