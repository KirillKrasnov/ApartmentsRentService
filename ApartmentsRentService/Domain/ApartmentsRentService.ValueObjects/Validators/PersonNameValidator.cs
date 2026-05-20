using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Exceptions;

namespace ApartmentsRentService.ValueObjects.Validators;

public class PersonNameValidator : IValidator<string>
{
    public static int MAX_LENGTH => 50;

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidPersonNameException(
                "Имя пользователя не может быть пустым.");

        if (value.Length > MAX_LENGTH)
            throw new InvalidPersonNameException(
                $"Имя пользователя не может быть длиннее {MAX_LENGTH} символов.");
    }
}