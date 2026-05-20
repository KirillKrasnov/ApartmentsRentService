using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Validators;
namespace ApartmentsRentService.ValueObjects;

public class Address(string value) : ValueObject<string> (
    new AddressValidator(), value.Trim() )
{

}
