namespace ApartmentsRentService.ValueObjects.Exceptions.ApartmentsTitleExceptions;

public class ApartmentTitleNullOrWhiteSpaceException() 
    : ValueObjectException("Название квартиры не может быть пустым.")
{
}
