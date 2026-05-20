using ApartmentsRentService.Domain.Entities;

namespace ApartmentsRentService.Domain.Exceptions;

public class LandlordEditApartmentException(
    Apartment apartment,
    Landlord landlord) : DomainException(
        $"Владелец квартиры с ID {landlord.Id} не может редактировать квартиру с ID " +
        $"{apartment.Id} потому что он не является собственником.")
{
    public Apartment Apartment => apartment;

    public Landlord Landlord => landlord;
}