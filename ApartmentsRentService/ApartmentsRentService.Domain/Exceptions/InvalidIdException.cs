namespace ApartmentsRentService.Domain.Exceptions;


public class InvalidIdException : DomainException
{
    public InvalidIdException() : base("ID должен быть > 0.")
    {

    }
}