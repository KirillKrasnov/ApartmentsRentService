
namespace ApartmentsRentService.ValueObjects.Exceptions.ApartmentsDescriptionExceptions;

public class ApartmentDescriptionNullOrWhiteSpaceException() 
    : ValueObjectException("Описание квартиры не может быть пустым.")
{
}