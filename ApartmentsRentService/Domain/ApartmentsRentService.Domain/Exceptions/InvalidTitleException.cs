namespace ApartmentsRentService.Domain.Exceptions;


public class InvalidTitleException : DomainException
{
    public InvalidTitleException(string message) : base(message)  
    {

    }
}