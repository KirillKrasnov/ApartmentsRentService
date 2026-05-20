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
        Money price, Address address, Landlord landlord)
        : this(Guid.NewGuid(), title, description, price, address, landlord)
    {}

    public void ChangePrice(Landlord landlord, Money price)
    {
        if (landlord == null)
            throw new ArgumentNullException(nameof(landlord));

        if (landlord.Id != Landlord.Id)
            throw new LandlordEditApartmentException(this, landlord);

        PricePerNight = price
            ?? throw new ArgumentNullException(nameof(price));
    }

    public void ChangeAddress(Landlord landlord, Address address)
    {
        if (landlord == null)
            throw new ArgumentNullException(nameof(landlord));

        if (landlord.Id != Landlord.Id)
            throw new LandlordEditApartmentException(this, landlord);

        Address = address
            ?? throw new ArgumentNullException(nameof(address));
    }

    public void ChangeTitle(Landlord landlord, ApartmentTitle title)
    {
        if (landlord == null)
            throw new ArgumentNullException(nameof(landlord));

        if (landlord.Id != Landlord.Id)
            throw new LandlordEditApartmentException(this, landlord);

        Title = title
            ?? throw new ArgumentNullException(nameof(title));
    }

    public void ChangeDescription(Landlord landlord, ApartmentDescription description)
    {
        if (landlord == null)
            throw new ArgumentNullException(nameof(landlord));

        if (landlord.Id != Landlord.Id)
            throw new LandlordEditApartmentException(this, landlord);

        Description = description
            ?? throw new ArgumentNullException(nameof(description));
    }
}