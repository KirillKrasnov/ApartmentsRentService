namespace ApartmentsRentService.ValueObjects.Exceptions.ApartmentsDescriptionExceptions;

public class ApartmentDescriptionTooLongException(
    string description,
    int maxLength)
    : ValueObjectException(
        $"Описание квартиры превышает максимальную длину {maxLength}.")
{
    public string Description => description;

    public int MaxLength => maxLength;
}