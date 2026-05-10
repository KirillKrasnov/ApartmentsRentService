namespace ApartmentsRentService.Domain.Exceptions;


public class InvalidNameException : DomainException
{
    public InvalidNameException(string name) : base ($"Имя {name} некорректно")
    {

    }
}