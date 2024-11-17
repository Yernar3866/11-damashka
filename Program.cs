using System.Collections.Generic;
using System;

interface IHotelService
{
    List<string> SearchHotels(string location);
}

class HotelService : IHotelService
{
    public List<string> SearchHotels(string location)
    {
        return new List<string> { "Отель 1", "Отель 2" };
    }
}

interface IBookingService
{
    void BookHotel(string hotelName, string userName);
}

class BookingService : IBookingService
{
    public void BookHotel(string hotelName, string userName)
    {
        Console.WriteLine($"Бронирование: {hotelName} для пользователя {userName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IHotelService hotelService = new HotelService();
        IBookingService bookingService = new BookingService();

        Console.WriteLine("Доступные отели:");
        foreach (var hotel in hotelService.SearchHotels("Алматы"))
        {
            Console.WriteLine($"- {hotel}");
        }

        bookingService.BookHotel("Отель 1", "Ернар");
    }
}
