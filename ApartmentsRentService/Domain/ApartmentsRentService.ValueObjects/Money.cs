using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Validators;

namespace ApartmentsRentService.ValueObjects;

public class Money : ValueObject<decimal>
{
    private Money()
        : base(new MoneyValidator(), 0)
    {
    }

    public Money(decimal amount)
        : base(
            new MoneyValidator(),
            Math.Round(amount, 2, MidpointRounding.AwayFromZero))
    {
    }

    public static Money operator +(Money m1, Money m2)
        => new(m1.Value + m2.Value);

    public static Money operator -(Money m1, Money m2)
        => new(m1.Value - m2.Value);

    public static bool operator >(Money m1, Money m2)
        => m1.Value > m2.Value;

    public static bool operator <(Money m1, Money m2)
        => m1.Value < m2.Value;

    public static bool operator >=(Money m1, Money m2)
        => m1.Value >= m2.Value;

    public static bool operator <=(Money m1, Money m2)
        => m1.Value <= m2.Value;
}