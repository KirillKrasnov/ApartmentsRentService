namespace ApartmentsRentService.ValueObjects.Exceptions;

public class InvalidAddressException : ValueObjectException
{
    public InvalidAddressException(string address) : base($"Адрес {address} некорректен") { }
}


    
    
    
    
    

