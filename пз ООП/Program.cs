using System;
using System.Collections.Generic;
using System.Linq;

//клас але поки не відомо для чого
class Hotel

{
    public string Name { get; set; }
    public int Stars { get; set; }
    public string Adress { get; set; }
    public int Rating { get; set; }

    public Hotel(string name, int stars, string adress, int rating)

    {
        Name = name;
        Stars = stars;
        Adress = adress;
        Rating = rating;


    }

    class HotelList
    {
        private List<Hotel> hotels;

        public HotelList()
        {
            hotels = new List<Hotel>();
        }

        public void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }

        public void RemoveHotel(Hotel hotel)
        {
            hotels.Remove(hotel);
        }

        public Hotel GetHighestRatedHotel()
        {
            return hotels.OrderByDescending(h => h.Rating).FirstOrDefault();
        }

        public List<Hotel> GetHotelsWithRatingAtLeast(int minRating)
        {
            return hotels.Where(h => h.Rating >= minRating).ToList();
        }

        static void Main(string[] args)
        {
            HotelList hotelList = new HotelList();

            hotelList.AddHotel(new Hotel("Готель 1", 5, "Адреса 1", 8));
            hotelList.AddHotel(new Hotel("Готель 2", 4, "Адреса 2", 7));
            hotelList.AddHotel(new Hotel("Готель 3", 3, "Адреса 3", 6));
            hotelList.AddHotel(new Hotel("Готель 4", 5, "Адреса 4", 9));
            hotelList.AddHotel(new Hotel("Готель 5", 5, "Адреса 5", 10));
            hotelList.AddHotel(new Hotel("Готель 6", 4, "Адреса 6", 2));
            hotelList.AddHotel(new Hotel("Готель 7", 3, "Адреса 7", 6));
            hotelList.AddHotel(new Hotel("Готель 8", 5, "Адреса 8", 4));
            hotelList.AddHotel(new Hotel("Готель 9", 5, "Адреса 9", 8));
            hotelList.AddHotel(new Hotel("Готель 10", 4, "Адреса 10", 7));

            Hotel highestRatedHotel = hotelList.GetHighestRatedHotel();

            Console.WriteLine("Готель з найвищим рейтингом:");
            Console.WriteLine($"{highestRatedHotel.Name} - {highestRatedHotel.Rating}");

            List<Hotel> highRatedHotels = hotelList.GetHotelsWithRatingAtLeast(7);
            Console.WriteLine("\nГотелi з рейтингом не менше 7:");
            foreach (var hotel in highRatedHotels)
            {
                Console.WriteLine($"{hotel.Name} - {hotel.Rating}");
            }
        }
    }
}