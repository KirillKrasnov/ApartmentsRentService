namespace ApartmentsRentService.ValueObjects.Exceptions.ApartmentsTitleExceptions;

public class ApartmentTitleTooLongException(string title, int maxLength)
    : ValueObjectException($"Название квартиры превышает максимальную длину {maxLength}.")
{
    public string Title => title;

    public int MaxLength => maxLength;
}