using System;
using System.IO;

namespace _03.Movie_Destination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            
            double price = 0;

            if (destination == "Dubai")
            {
                if (season == "Winter")
                {
                    price = 45000;
                }
                else if (season == "Summer")
                {
                    price = 40000;
                }
            }
            else if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    price = 17000;
                }
                else if (season == "Summer")
                {
                    price = 12500;
                }
            }
            else if (destination == "London")
            {
                if (season == "Winter")
                {
                    price = 24000;
                }
                else if (season == "Summer")
                {
                    price = 20250;
                }
            }
            double totalPrice = price * days;
            
            if (destination == "Dubai")
            {
                totalPrice *= 0.7;
            }
            else if (destination == "Sofia")
            {
                totalPrice *= 1.25;
            }
            if (budget >= totalPrice)
            {
                double leftMoney = budget - totalPrice;
                Console.WriteLine($"The budget for the movie is enough! We have {leftMoney:f2} leva left!");
            }
            else
            {
                double neededMoney = totalPrice - budget;
                Console.WriteLine($"The director needs {neededMoney:f2} leva more!");
            }
        }
    }
}
