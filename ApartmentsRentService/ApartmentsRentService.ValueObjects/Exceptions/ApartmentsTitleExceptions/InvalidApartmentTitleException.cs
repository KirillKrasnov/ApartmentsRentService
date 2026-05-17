namespace ApartmentsRentService.ValueObjects.Exceptions.ApartmentsTitleExceptions;

public class InvalidApartmentTitleException(string title) : ValueObjectException(
        $"Название квартиры {title} некорректно.")
{
    public string Title => title;
}
