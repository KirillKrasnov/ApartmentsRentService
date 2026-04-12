using ApartmentsRentService.Domain.Exceptions;
namespace ApartmentsRentService.Domain.Exceptions;


public class InvalidLandlordNameException : DomainException
{
    public InvalidLandlordNameException() : base ("Имя не может быть пустым")
    {

    }
}