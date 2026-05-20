using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Validators;

namespace ApartmentsRentService.ValueObjects;

public class Email : ValueObject<string>
{
    public Email(string value)
        : base(new EmailValidator(), Normalize(value))
    {
    }

    private static string Normalize(string value)
    {
        return value.Trim().ToLowerInvariant();
    }

    public override string ToString()
    {
        return Value;
    }
}