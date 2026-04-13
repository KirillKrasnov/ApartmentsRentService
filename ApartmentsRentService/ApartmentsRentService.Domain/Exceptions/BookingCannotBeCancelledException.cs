namespace ApartmentsRentService.Domain.Exceptions;

public class BookingCannotBeCancelledException : DomainException
{
    public BookingCannotBeCancelledException(string message)
        : base(message)
    {
    }
}