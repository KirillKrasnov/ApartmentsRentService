using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Exceptions;

namespace ApartmentsRentService.ValueObjects.Validators;

public class AddressValidator : IValidator<string>
{
    public static int MIN_LENGTH => 3;
    public static int MAX_LENGTH => 200;
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidAddressException(value);

        if (value.Length < MIN_LENGTH)
            throw new InvalidAddressException(value);

        if (value.Length > MAX_LENGTH)
            throw new InvalidAddressException(value);
    }
}