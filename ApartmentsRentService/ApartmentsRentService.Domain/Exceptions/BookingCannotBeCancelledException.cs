using ApartmentsRentService.Domain.Entities;

namespace ApartmentsRentService.Domain.Exceptions;

public class BookingCannotBeCancelledException(Booking booking) : DomainException(
        $"Невозможно отменить бронирование {booking.Id}, так как его статус {booking.Status}.")
{
    public Booking Booking => booking;
}