namespace ApartmentsRentService.ValueObjects.Exceptions;

public class InvalidMoneyException : ValueObjectException
{
    public InvalidMoneyException() : base("Сумма не может быть меньше нуля") { }
}

