using ApartmentsRentService.Domain.Entities;

namespace ApartmentsRentService.Domain.Exceptions;

public class BookingAlreadyCancelledException(Booking booking)
    : DomainException(
        $"Бронирование {booking.Id} уже отменено.")
{
    public Booking Booking => booking;
}