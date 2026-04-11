using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Validators;

namespace ApartmentsRentService.ValueObjects;

public class Email : ValueObject<string>
{
    public Email(string value)
        : base(new EmailValidator(), Normalize(value))
    {
    }

    public string GetDomain()
    {
        return Value.Split('@')[1];
    }

    public bool IsFromDomain(string domain)
    {
        return GetDomain().Equals(domain, StringComparison.OrdinalIgnoreCase);
    }

    private static string Normalize(string value)
    {
        return value.Trim().ToLowerInvariant();
    }
}