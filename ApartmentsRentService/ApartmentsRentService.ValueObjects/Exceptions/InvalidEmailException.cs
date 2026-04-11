namespace ApartmentsRentService.ValueObjects.Exceptions;

public class InvalidEmailException : ValueObjectException
{ 
    public InvalidEmailException() : base("Некорректный Email") { }
}

