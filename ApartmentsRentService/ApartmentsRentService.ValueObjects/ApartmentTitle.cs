using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Validators;

namespace ApartmentsRentService.ValueObjects;

public class ApartmentTitle : ValueObject<string>
{
    public ApartmentTitle(string value)
        : base(new ApartmentTitleValidator(), value)
    {
    }
}