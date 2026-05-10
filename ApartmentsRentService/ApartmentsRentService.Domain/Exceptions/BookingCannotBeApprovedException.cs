namespace ApartmentsRentService.Domain.Exceptions;

public class BookingCannotBeApprovedException : DomainException
{
    public BookingCannotBeApprovedException()
        : base("Невозможно подтвердить бронирование, так как его статус не Pending")
    {
    }
}