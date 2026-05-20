using ApartmentsRentService.Domain.Entities;

namespace ApartmentsRentService.Domain.Exceptions;

public class LandlordCancelBookingException(Booking booking, Landlord landlord)
    : DomainException(
        $"Арендодатель с идентификатором {landlord.Id} не может отменить " +
        $"бронирование {booking.Id}, так как квартира ему не принадлежит.")
{
    public Booking Booking => booking;

    public Landlord Landlord => landlord;
}