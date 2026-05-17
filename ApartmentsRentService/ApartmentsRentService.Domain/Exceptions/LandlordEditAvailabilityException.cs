using ApartmentsRentService.Domain.Entities;

namespace ApartmentsRentService.Domain.Exceptions;

public class LandlordEditAvailabilityException(Availability availability, Landlord landlord)
    : DomainException(
        $"Арендодатель с ID {landlord.Id} не может изменять доступность" +
        $" {availability.Id}, так как квартира ему не принадлежит.")
{
    public Availability Availability => availability;

    public Landlord Landlord => landlord;
}