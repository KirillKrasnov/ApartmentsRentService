namespace ApartmentsRentService.ValueObjects.Exceptions;

public sealed class InvalidAddressException : ValueObjectException
{
    public InvalidAddressException() : base("Адрес не должен быть пустой") { }
}


    
    
    
    
    

