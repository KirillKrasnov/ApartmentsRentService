namespace ApartmentsRentService.Domain.Exceptions;

public class BookingCannotBeApprovedException : DomainException
{
    public BookingCannotBeApprovedException()
        : base("Можно подтвердить только бронь со статусом Pending (В ожидании)")
    {
    }
}