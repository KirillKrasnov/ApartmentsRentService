namespace ApartmentsRentService.ValueObjects.Exceptions.ApartmentsDescriptionExceptions;

public class InvalidApartmentDescriptionException(string description)
    : ValueObjectException(
        $"Описание квартиры {description} некорректно.")
{
    public string Description => description;
}