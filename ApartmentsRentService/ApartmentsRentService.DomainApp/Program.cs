using ApartmentsRentService.Domain.Entities;
using ApartmentsRentService.ValueObjects;

Console.WriteLine("=== Демонстрация доменной модели ===\n");


// Арендодатель
var landlord = new Landlord(
    "Васян",
    new Email("Vasyan@gmail.com"));

Console.WriteLine(
    $"Создан арендодатель: {landlord.Name}");


// Арендатор
var tenant = new Tenant(
    "Ванек",
    new Email("vanek@gmail.com"));

Console.WriteLine(
    $"Создан арендатор: {tenant.Name}");


// Квартира
var apartment = new Apartment(
    new ApartmentTitle("Квартира в центре"),
    new ApartmentDescription("Отличная хатка"),
    new Money(10000),
    new Address("Майами"),
    landlord);

Console.WriteLine(
    $"Создана квартира: {apartment.Title.Value}");


// Диапазон дат
var dateRange = new DateRange(
    new DateTime(2026, 1, 1),
    new DateTime(2026, 1, 31));

Console.WriteLine(
    $"Диапазон дат: {dateRange.StartDate:d} - {dateRange.EndDate:d}");


// Бронь
var booking = new Booking(
    apartment,
    tenant,
    dateRange);

Console.WriteLine(
    $"Создана бронь со статусом: {booking.Status}");


// Подтверждение брони
try
{
    landlord.ApproveBooking(booking);

    Console.WriteLine(
        $"Бронь подтверждена. Новый статус: {booking.Status}");

    landlord.ApproveBooking(booking);
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}