using ApartmentsRentService.Domain.Exceptions;
namespace ApartmentsRentService.Domain.Exceptions;


public class InvalidLandlordIdException : DomainException
{
    public InvalidLandlordIdException() : base("ID арендодателя должен быть > 0.")
    {

    }
}