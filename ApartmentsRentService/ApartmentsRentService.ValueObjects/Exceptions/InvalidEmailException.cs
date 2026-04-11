namespace ApartmentsRentService.ValueObjects.Exceptions;

public sealed class InvalidEmailException : ValueObjectException
{ 
    public InvalidEmailException() : base("Некорректный Email") { }
}

