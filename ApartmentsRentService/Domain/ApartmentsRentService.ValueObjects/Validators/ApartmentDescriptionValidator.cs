using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Exceptions.ApartmentsDescriptionExceptions;

namespace ApartmentsRentService.ValueObjects.Validators;

public class ApartmentDescriptionValidator : IValidator<string>
{
    public static int MAX_LENGTH => 2000;

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ApartmentDescriptionNullOrWhiteSpaceException();

        if (value.Length > MAX_LENGTH)
            throw new ApartmentDescriptionTooLongException(value, MAX_LENGTH);
    }
}