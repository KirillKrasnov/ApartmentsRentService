namespace ApartmentsRentService.ValueObjects.Exceptions;

public class InvalidDateRangeException : ValueObjectException
{
    public InvalidDateRangeException(DateTime startDate, DateTime endDate)
        : base($"Дата начала {startDate} должна быть раньше даты окончания {endDate}") {}
}