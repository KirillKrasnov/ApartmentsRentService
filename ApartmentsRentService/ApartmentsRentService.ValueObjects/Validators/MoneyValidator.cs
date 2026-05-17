using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Exceptions;

namespace ApartmentsRentService.ValueObjects.Validators;

public class MoneyValidator : IValidator<decimal>
{
    public static decimal MAX_VALUE => 100000000m;

    public void Validate(decimal value)
    {
        if (value <= 0)
            throw new InvalidMoneyException(value);

        if (value > MAX_VALUE)
            throw new InvalidMoneyException(value);

        if (!IsValidAmount(value))
            throw new InvalidMoneyException(value);
    }

    private bool IsValidAmount(decimal value)
    {
        value *= 100;
        value -= (int)value;

        return value == 0m;
    }
}