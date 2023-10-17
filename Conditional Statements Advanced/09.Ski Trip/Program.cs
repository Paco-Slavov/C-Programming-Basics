using System;

namespace _09.Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double roomPrice = 18.00;
            double apartmentPrice = 25.00;
            double presidentApartmentPrice = 35.00;

            double price = 0.00;

            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string review = Console.ReadLine();

            switch (room)
            {
                case "room for one person":
                    price = (days - 1) * roomPrice;
                    break;
                case "apartment":
                    if (days < 10)
                        price = (days - 1) * 0.70 * apartmentPrice;
                    else if (days <= 15)
                        price = (days - 1) * 0.65 * apartmentPrice;
                    else if (days > 15)
                        price = (days - 1) * 0.50 * apartmentPrice;
                    break;
                case "president apartment":
                    if (days < 10)
                        price = (days - 1) * 0.90 * presidentApartmentPrice;
                    else if (days <= 15)
                        price = (days - 1) * 0.85 * presidentApartmentPrice;
                    else if (days > 15)
                        price = (days - 1) * 0.80 * presidentApartmentPrice;
                    break;
            }
            if (review == "positive")
                price *= 1.25;
            else
                price *= 0.90;

            Console.WriteLine("{0:0.00}", price);
        }
    }
}
