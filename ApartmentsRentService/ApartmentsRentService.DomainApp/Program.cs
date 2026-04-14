using ApartmentsRentService.Domain.Entities;
using ApartmentsRentService.ValueObjects;

Console.WriteLine("=== Демонстрация доменной модели ===\n");

var email = new Email("Vasyan@gmail.com");
var landlord = new Landlord(1, "Васян", email);
Console.WriteLine($"Создан арендодатель: {landlord.Name}");


var tenant = new Tenant(1, "Ванек", new Email("vanek@gmail.com"));
Console.WriteLine($"Создан арендатор: {tenant.Name}");


var price = new Money(10000);
var address = new Address("Майами");
var apartment = new Apartment(
    1,
    "Квартира в центре",
    "Отличная хатка",
    price,
    address,
    landlord.Id);
Console.WriteLine($"Создана квартира: {apartment.Title}, цена: {apartment.PricePerNight.Value}");


var dateRange = new DateRange(
    new DateTime(2026, 1, 1),
    new DateTime(2026, 1, 31));
Console.WriteLine($"Диапазон дат: {dateRange.StartDate:d} - {dateRange.EndDate:d}");

var booking = new Booking(
    1,
    apartment.Id,
    tenant.Id,
    dateRange);
Console.WriteLine($"Создана бронь со статусом: {booking.Status}");


try
{
    booking.Approve();
    booking.Approve();

}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}