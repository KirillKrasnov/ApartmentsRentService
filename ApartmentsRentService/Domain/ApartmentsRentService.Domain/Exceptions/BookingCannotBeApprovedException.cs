using ApartmentsRentService.Domain.Entities;

namespace ApartmentsRentService.Domain.Exceptions;

public class BookingCannotBeApprovedException(Booking booking) : DomainException(
        $"Невозможно подтвердить бронирование {booking.Id}, так как его статус {booking.Status}.")
{
    public Booking Booking => booking;
}