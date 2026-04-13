using ApartmentsRentService.Domain.Entities;
using ApartmentsRentService.ValueObjects;

var email = new Email("Vasyan@gmail.com");
var landlord = new Landlord(1, "Васян", email);
var tenant = new Tenant(1, "Ванек", new Email("vanek@gmail.com"));


var price = new Money(10000);
var address = new Address("Майами");
var apartment = new Apartment(
    1,
    "Квартира в центре",
    "Отличная хатка",
    price,
    address,
    landlord.Id);


var daterange = new DateRange(
    new DateTime(2026, 1, 1),
    new DateTime(2026, 1, 31));
var booking = new Booking(
    1,
    apartment.Id,
    tenant.Id,
    daterange);

booking.Approve();