using System.Text.RegularExpressions;
using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Exceptions;

namespace ApartmentsRentService.ValueObjects.Validators;

public class EmailValidator : IValidator<string>
{
    public static int MAX_LENGTH => 50;

    private const string EMAIL_PATTERN =
        @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidEmailException(value);

        if (value.Length > MAX_LENGTH)
            throw new InvalidEmailException(value);

        if (!Regex.IsMatch(value, EMAIL_PATTERN))
            throw new InvalidEmailException(value);
    }
}