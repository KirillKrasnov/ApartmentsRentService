using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Exceptions.ApartmentsTitleExceptions;

namespace ApartmentsRentService.ValueObjects.Validators;

public class ApartmentTitleValidator : IValidator<string>
{
    public static int MAX_LENGTH => 100;

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ApartmentTitleNullOrWhiteSpaceException();

        if (value.Length > MAX_LENGTH)
            throw new ApartmentTitleTooLongException(value, MAX_LENGTH);
    }
}