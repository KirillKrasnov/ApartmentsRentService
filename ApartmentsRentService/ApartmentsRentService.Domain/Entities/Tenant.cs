using ApartmentsRentService.Domain.Entities.Base;
using ApartmentsRentService.Domain.Exceptions;
using ApartmentsRentService.ValueObjects;

namespace ApartmentsRentService.Domain.Entities;

public class Tenant : Entity<Guid>
{
    public string Name { get; private set; }

    public Email Email { get; private set; }

    protected Tenant()
    {
    }

    protected Tenant(
        Guid id,
        string name,
        Email email)
        : base(id)
    {
        if (id == Guid.Empty)
            throw new InvalidIdException();

        if (string.IsNullOrWhiteSpace(name))
            throw new InvalidNameException(name);

        Name = name.Trim();

        Email = email
            ?? throw new ArgumentNullException(nameof(email));
    }

    public Tenant(string name, Email email) : base(Guid.NewGuid())
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new InvalidNameException(name);

        Name = name.Trim();

        Email = email
            ?? throw new ArgumentNullException(nameof(email));
    }

    public void ChangeName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new InvalidNameException(name);

        Name = name.Trim();
    }

    public void ChangeEmail(Email email)
    {
        Email = email
            ?? throw new ArgumentNullException(nameof(email));
    }
}