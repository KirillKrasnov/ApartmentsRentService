using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Exceptions;
namespace ApartmentsRentService.ValueObjects;

public class DateRange 
{
    DateTime StartDate { get; }
    DateTime EndDate { get; }

    public DateRange(DateTime startDate, DateTime endDate)
    {
        if (startDate > endDate)
            throw new InvalidDateRangeException();
    }

    public bool Includes(DateTime value) 
        => value >= StartDate && EndDate <= value;

    public bool Overlaps(DateRange other) 
        => StartDate < other.EndDate && other.StartDate < EndDate;

    public TimeSpan Duration => EndDate - StartDate;
}
