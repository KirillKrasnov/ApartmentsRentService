using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Exceptions;

namespace ApartmentsRentService.ValueObjects.Validators;

public class AddressValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidAddressException(value);

        if (value.Length < 3)
            throw new InvalidAddressException(value);

        if (value.Length > 200)
            throw new InvalidAddressException(value);
    }
}