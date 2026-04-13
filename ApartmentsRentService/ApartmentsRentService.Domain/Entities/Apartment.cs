using ApartmentsRentService.Domain.Exceptions;
using ApartmentsRentService.ValueObjects;

namespace ApartmentsRentService.Domain.Entities;

public class Apartment
{ 
    public int Id { get; }
    public string Title { get; private set; }
    public string Description { get; private set; }

    public Money PricePerNight { get; private set; }
    public Address Address { get; private set; }

    public int LandlordId { get; }

    public Apartment(int id, string title, string description, Money price, Address address, int landlordid)
    {
        if (id <= 0)
            throw new InvalidIdException();

        if (string.IsNullOrWhiteSpace(title))
            throw new InvalidTitleException("Заголовок не может быть пустым");

        if (landlordid <= 0)
            throw new InvalidIdException();

        Id = id;
        Title = title;
        Description = description;
        PricePerNight = price;
        Address = address;
        LandlordId = landlordid;
    }

    public void ChangeTitle(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new InvalidTitleException("Заголовок не может быть пустым");
        Title = title.Trim();
    }

    public void ChangeDescription(string description)
    {
        Description = description.Trim();
    }

    public void ChangePrice(Money price) => PricePerNight = price;

    public void ChangeAddress(Address address) => Address = address;


}

