using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Validators;

namespace ApartmentsRentService.ValueObjects;

public class PersonName : ValueObject<string>
{
    public PersonName(string value)
        : base(new PersonNameValidator(), value.Trim()) { }

    public override string ToString()
    {
        return Value;
    }
}