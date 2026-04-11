using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Exceptions;
namespace ApartmentsRentService.ValueObjects.Validators;

public sealed class AddressValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if(string.IsNullOrEmpty(value)) 
            throw new InvalidAddressException();
    }
}