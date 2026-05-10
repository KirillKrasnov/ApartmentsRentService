using ApartmentsRentService.ValueObjects.Base;

namespace ApartmentsRentService.ValueObjects.Validators;

public class ApartmentDescriptionValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Описание квартиры не может быть пустым");

        if (value.Length > 500)
            throw new ArgumentException("Слишком длинное описание квартиры");
    }
}