namespace ApartmentsRentService.ValueObjects.Exceptions;

public class InvalidPersonNameException : ValueObjectException
{
    public InvalidPersonNameException(string message)
        : base(message)
    {
    }
}