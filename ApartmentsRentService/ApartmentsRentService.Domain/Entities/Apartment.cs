using ApartmentsRentService.Domain.Entities.Base;
using ApartmentsRentService.Domain.Exceptions;
using ApartmentsRentService.ValueObjects;

namespace ApartmentsRentService.Domain.Entities;

public class Apartment : Entity<Guid>
{
    public ApartmentTitle Title { get; private set; }

    public ApartmentDescription Description { get; private set; }

    public Money PricePerNight { get; private set; }

    public Address Address { get; private set; }

    public Landlord Landlord { get; private set; }

    protected Apartment()
    {
    }

    protected Apartment(
        Guid id,
        ApartmentTitle title,
        ApartmentDescription description,
        Money price,
        Address address,
        Landlord landlord)
        : base(id)
    {
        if (id == Guid.Empty)
            throw new InvalidIdException();

        Title = title
            ?? throw new ArgumentNullException(nameof(title));

        Description = description
            ?? throw new ArgumentNullException(nameof(description));

        PricePerNight = price
            ?? throw new ArgumentNullException(nameof(price));

        Address = address
            ?? throw new ArgumentNullException(nameof(address));

        Landlord = landlord
            ?? throw new ArgumentNullException(nameof(landlord));
    }

    public Apartment(ApartmentTitle title, ApartmentDescription description, 
        Money price, Address address, Landlord landlord) : base(Guid.NewGuid())
    {
        Title = title
            ?? throw new ArgumentNullException(nameof(title));

        Description = description
            ?? throw new ArgumentNullException(nameof(description));

        PricePerNight = price
            ?? throw new ArgumentNullException(nameof(price));

        Address = address
            ?? throw new ArgumentNullException(nameof(address));

        Landlord = landlord
            ?? throw new ArgumentNullException(nameof(landlord));
    }

    public void ChangePrice(Money price)
    {
        PricePerNight = price
            ?? throw new ArgumentNullException(nameof(price));
    }

    public void ChangeAddress(Address address)
    {
        Address = address
            ?? throw new ArgumentNullException(nameof(address));
    }

    public void ChangeTitle(ApartmentTitle title)
    {
        Title = title
            ?? throw new ArgumentNullException(nameof(title));
    }

    public void ChangeDescription(ApartmentDescription description)
    {
        Description = description
            ?? throw new ArgumentNullException(nameof(description));
    }
}