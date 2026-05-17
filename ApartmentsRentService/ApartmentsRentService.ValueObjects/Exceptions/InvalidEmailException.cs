namespace ApartmentsRentService.ValueObjects.Exceptions;

public class InvalidEmailException : ValueObjectException
{ 
    public InvalidEmailException(string email) : base($"Email {email} имеет некорректный формат") { }
}

