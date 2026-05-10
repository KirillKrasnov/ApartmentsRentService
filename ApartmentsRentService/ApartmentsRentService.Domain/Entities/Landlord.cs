using ApartmentsRentService.Domain.Entities.Base;
using ApartmentsRentService.Domain.Enums;
using ApartmentsRentService.Domain.Exceptions;
using ApartmentsRentService.ValueObjects;

namespace ApartmentsRentService.Domain.Entities;

public class Landlord : Entity<Guid>
{
    public string Name { get; private set; }

    public Email Email { get; private set; }

    protected Landlord()
    {
    }

    protected Landlord(
        Guid id,
        string name,
        Email email)
        : base(id)
    {
        if (id == Guid.Empty)
            throw new InvalidIdException();

        if (string.IsNullOrWhiteSpace(name))
            throw new InvalidNameException(
                "Имя арендодателя не может быть пустым.");

        Name = name.Trim();

        Email = email
            ?? throw new ArgumentNullException(nameof(email));
    }

    public Landlord(string name, Email email) : base(Guid.NewGuid())
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new InvalidNameException(name);

        Name = name.Trim();

        Email = email
            ?? throw new ArgumentNullException(nameof(email));
    }

    public void ChangeName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new InvalidNameException(name);

        Name = name.Trim();
    }

    public void ChangeEmail(Email email)
    {
        Email = email
            ?? throw new ArgumentNullException(nameof(email));
    }

    public void ApproveBooking(Booking booking)
    {
        if (booking == null)
            throw new ArgumentNullException(nameof(booking));

        booking.SetStatus(BookingStatus.Approved);
    }

    public void RejectBooking(Booking booking)
    {
        if (booking == null)
            throw new ArgumentNullException(nameof(booking));

        booking.SetStatus(BookingStatus.Rejected);
    }

    public void CancelBooking(Booking booking)
    {
        if (booking == null)
            throw new ArgumentNullException(nameof(booking));

        booking.SetStatus(BookingStatus.Cancelled);
    }
}