using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Validators;

namespace ApartmentsRentService.ValueObjects;

public class ApartmentDescription : ValueObject<string>
{
    public ApartmentDescription(string value)
        : base(new ApartmentDescriptionValidator(), value)
    {
    }
}