namespace ApartmentsRentService.ValueObjects.Exceptions;

public class InvalidDateRangeException : ValueObjectException
{
    public InvalidDateRangeException() : base("Дата начала аренды должна быть раньше даты окончания") { }
}

