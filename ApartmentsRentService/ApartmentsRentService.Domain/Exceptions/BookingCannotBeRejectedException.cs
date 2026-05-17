using ApartmentsRentService.Domain.Entities;

namespace ApartmentsRentService.Domain.Exceptions;

public class BookingCannotBeRejectedException(Booking booking)
    : DomainException(
        $"Невозможно отклонить бронирование {booking.Id}, так как его статус {booking.Status}.")
{
    public Booking Booking => booking;
}