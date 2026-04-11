using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Exceptions;
namespace ApartmentsRentService.ValueObjects.Validators;

public sealed class EmailValidator : IValidator<string>
{ 
    public void Validate(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new InvalidEmailException();
        if (!value.Contains("@"))
            throw new InvalidEmailException();
        if (value.Length == 50)
            throw new InvalidEmailException();

    }
}

