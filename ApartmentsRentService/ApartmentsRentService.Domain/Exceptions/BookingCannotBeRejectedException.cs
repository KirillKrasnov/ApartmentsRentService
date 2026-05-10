namespace ApartmentsRentService.Domain.Exceptions;

public class BookingCannotBeRejectedException : DomainException
{
    public BookingCannotBeRejectedException()
        : base("Невозможно отклонить бронирование, так как его статус не Pending")
    {
    }
}