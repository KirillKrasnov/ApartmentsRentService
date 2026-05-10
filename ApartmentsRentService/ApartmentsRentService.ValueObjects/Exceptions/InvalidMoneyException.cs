namespace ApartmentsRentService.ValueObjects.Exceptions;

public class InvalidMoneyException : ValueObjectException
{
    public InvalidMoneyException(decimal amount) : base($"Сумма {amount} не может быть отрицательной") { }
}

