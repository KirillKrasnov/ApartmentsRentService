namespace ApartmentsRentService.ValueObjects.Exceptions;

public sealed class InvalidMoneyException : ValueObjectException
{
    public InvalidMoneyException() : base("Сумма не может быть меньше нуля") { }
}

