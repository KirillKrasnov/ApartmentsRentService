namespace ApartmentsRentService.Domain.Exceptions;

public class BookingCannotBeRejectedException : DomainException
{
    public BookingCannotBeRejectedException()
        : base("Можно отклонить только бронь со статусом Pending (В ожидании)")
    {
    }
}