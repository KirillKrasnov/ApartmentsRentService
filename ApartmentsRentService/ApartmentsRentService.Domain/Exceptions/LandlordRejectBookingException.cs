using ApartmentsRentService.Domain.Entities;

namespace ApartmentsRentService.Domain.Exceptions;

public class LandlordRejectBookingException(Booking booking, Landlord landlord)
    : DomainException(
        $"Арендодатель с идентификатором {landlord.Id} не может отклонить " +
        $"бронирование {booking.Id}, так как квартира ему не принадлежит.")
{
    public Booking Booking => booking;

    public Landlord Landlord => landlord;
}