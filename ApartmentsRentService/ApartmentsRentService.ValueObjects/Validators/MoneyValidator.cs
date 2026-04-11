using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Exceptions;
namespace ApartmentsRentService.ValueObjects.Validators;

public sealed class MoneyValidator : IValidator<string>
{
    public void Validate(decimal value)
    {
        if (value< 0)
            throw new InvalidMoneyException();
    }
}