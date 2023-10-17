using System;

namespace _07.Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartment = 0;

            if (month == "May" || month == "October")
            {
                studio = 50 * nights;
                apartment = 65 * nights;

                if (nights > 14)
                {
                    studio = studio * 0.70;
                }
                else if (nights > 7)
                {
                    studio = studio * 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20 * nights;
                apartment = 68.70 * nights;

                if (nights > 14)
                {
                    studio = studio * 0.80;
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = 76 * nights;
                apartment = 77 * nights;
            }
            if (nights > 14)
            {
                apartment = apartment * 0.90;
            }
            Console.WriteLine($"Apartment: {apartment:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}