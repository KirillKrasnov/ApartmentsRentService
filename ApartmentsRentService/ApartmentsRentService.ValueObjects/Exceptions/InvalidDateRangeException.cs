namespace ApartmentsRentService.ValueObjects.Exceptions;

public sealed class InvalidDateRangeException : ValueObjectException
{
    public InvalidDateRangeException() : base("Дата начала аренды должна быть раньше даты окончания") { }
}

