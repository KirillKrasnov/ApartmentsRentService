using ApartmentsRentService.Domain.Exceptions;
using ApartmentsRentService.ValueObjects;
using ApartmentsRentService.ValueObjects.Exceptions;

namespace ApartmentsRentService.Domain.Entities;


public class Landlord
{ 
    public int Id { get; }
    public string Name { get; private set; }

    public Email Email { get; private set; }


    public Landlord(int id, string name, Email email)
    {

        if (id <= 0)
            throw new InvalidLandlordIdException();

        if (string.IsNullOrWhiteSpace(name)) throw new InvalidLandlordNameException();

        Id = id;
        Name = name.Trim();
        Email = email ?? throw new InvalidEmailException();
    }

    public void ChangeName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new InvalidLandlordNameException();
        Name = name.Trim();
    }

    public void ChangeEmail(Email email)
    {
        Email = email ?? throw new InvalidEmailException();
    }
}


