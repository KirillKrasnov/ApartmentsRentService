using ApartmentsRentService.ValueObjects.Base;
using ApartmentsRentService.ValueObjects.Exceptions;
namespace ApartmentsRentService.ValueObjects;

public class DateRange 
{
    public DateTime StartDate { get; }
    public DateTime EndDate { get; }

    public DateRange(DateTime startDate, DateTime endDate)
    {
        if (startDate > endDate)
            throw new InvalidDateRangeException();

        StartDate = startDate;
        EndDate = endDate;
    }

    public bool Includes(DateTime value) 
        => value >= StartDate && value <= EndDate;

    public bool Overlaps(DateRange other) 
        => StartDate < other.EndDate && other.StartDate < EndDate;

    public TimeSpan Duration => EndDate - StartDate;
}
