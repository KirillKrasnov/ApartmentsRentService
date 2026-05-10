using ApartmentsRentService.ValueObjects.Base;

namespace ApartmentsRentService.ValueObjects.Validators;

public class ApartmentTitleValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Заголовок квартиры не может быть пустым");

        if (value.Length > 100)
            throw new ArgumentException("Слишком длинный заголовок квартиры");
    }
}