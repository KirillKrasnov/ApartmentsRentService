using ApartmentsRentService.Domain.Entities.Base;
using ApartmentsRentService.Domain.Exceptions;
using ApartmentsRentService.ValueObjects;

namespace ApartmentsRentService.Domain.Entities;

public class Tenant : Entity<Guid>
{
    public PersonName Name { get; private set; }

    public Email Email { get; private set; }

    protected Tenant()
    {
    }

    protected Tenant(
        Guid id,
        PersonName name,
        Email email)
        : base(id)
    {
        if (id == Guid.Empty)
            throw new InvalidIdException();

        Name = name
            ?? throw new ArgumentNullException(nameof(name));

        Email = email
            ?? throw new ArgumentNullException(nameof(email));
    }

    public Tenant(PersonName name, Email email) : this(Guid.NewGuid(), name, email)
    {}

    public void ChangeName(PersonName name)
    {
        if (name == null)
            throw new ArgumentNullException(nameof(name));

        Name = name;
    }

    public void ChangeEmail(Email email)
    {
        Email = email
            ?? throw new ArgumentNullException(nameof(email));
    }
}