using ApartmentsRentService.Domain.Enums;
using ApartmentsRentService.Domain.Exceptions;
using ApartmentsRentService.ValueObjects;

namespace ApartmentsRentService.Domain.Entities;

public class Booking
{
    public int Id { get; }
    public int ApartmentId { get; }
    public int TenantId { get; }

    public DateRange DateRange { get; }
    public BookingStatus Status { get; private set; }

    public Booking(int id, int apartmentId, int tenantId, DateRange dateRange)
    {
        if (id <= 0)
            throw new InvalidIdException();
        if(apartmentId <= 0) 
            throw new InvalidIdException();
        if(tenantId <= 0)
            throw new InvalidIdException();
        if(dateRange == null)
            throw new ArgumentNullException(nameof(dateRange));

        Id = id;
        ApartmentId = apartmentId;
        TenantId = tenantId;
        DateRange = dateRange;
        Status = BookingStatus.Pending;
    }

    public void Approve()
    {
        if (Status != BookingStatus.Pending)
            throw new BookingCannotBeApprovedException();
        Status = BookingStatus.Approved;
    }

    public void Reject()
    {
        if (Status != BookingStatus.Pending)
            throw new BookingCannotBeRejectedException();
        Status = BookingStatus.Rejected;
    }
    public void Cancel()
    {
        if (Status == BookingStatus.Cancelled)
            throw new BookingCannotBeCancelledException("Бронь уже отменена");

        if (Status == BookingStatus.Rejected)
            throw new BookingCannotBeCancelledException("Бронь уже отклонена");

        Status = BookingStatus.Cancelled;
    }
}

