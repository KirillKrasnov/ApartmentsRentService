using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Exceptions;
namespace ApartmentsRentService.ValueObjects.Validators;

public class MoneyValidator : IValidator<decimal>
{
    public void Validate(decimal value)
    {
        if (value< 0)
            throw new InvalidMoneyException();
    }
}