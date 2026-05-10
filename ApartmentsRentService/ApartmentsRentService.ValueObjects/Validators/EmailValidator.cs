using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Exceptions;

namespace ApartmentsRentService.ValueObjects.Validators;

public class EmailValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidEmailException(value);

        if (!value.Contains("@"))
            throw new InvalidEmailException(value);

        if (!value.Contains("."))
            throw new InvalidEmailException(value);

        if (value.Length > 50)
            throw new InvalidEmailException(value);
    }
}