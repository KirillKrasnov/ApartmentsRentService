using ApartmentsRentService.Domain.Entities;

namespace ApartmentsRentService.Domain.Exceptions;

public class LandlordApproveBookingException(Booking booking, Landlord landlord)
    : DomainException(
        $"Арендодатель с идентификатором {landlord.Id} не может подтвердить" +
        $" бронирование {booking.Id}, так как квартира ему не принадлежит.")
{
    public Booking Booking => booking;

    public Landlord Landlord => landlord;
}