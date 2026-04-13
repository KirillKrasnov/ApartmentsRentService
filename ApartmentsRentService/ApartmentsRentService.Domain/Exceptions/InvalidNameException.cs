namespace ApartmentsRentService.Domain.Exceptions;


public class InvalidNameException : DomainException
{
    public InvalidNameException() : base ("Имя не может быть пустым")
    {

    }
}