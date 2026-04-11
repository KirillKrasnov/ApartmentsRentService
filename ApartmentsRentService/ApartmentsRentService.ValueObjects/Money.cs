using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Validators;

namespace AuctionTrading.Domain.ValueObjects
{ 
    public class Money(decimal amount) : ValueObject<decimal>(
        new MoneyValidator(),
        Math.Round(amount, 2, MidpointRounding.AwayFromZero))
    {
        public static Money operator +(Money m1, Money m2)
            => new(m1.Value + m2.Value);

    }
}