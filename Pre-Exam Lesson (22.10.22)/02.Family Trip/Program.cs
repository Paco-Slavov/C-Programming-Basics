using System;

namespace _02.Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int additionalFeesPercent = int.Parse(Console.ReadLine());

            if (nights > 7)
            {
                pricePerNight -= pricePerNight * 0.05;
            }

            double additionalFees = (additionalFeesPercent / 100.0) * budget;
            double totalPrice = (pricePerNight * nights) + additionalFees;

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Ivanovi will be left with {moneyLeft:f2} leva after vacation.");
            }
            else
            {
                double moneyMoreNeeded = totalPrice - budget;
                Console.WriteLine($"{moneyMoreNeeded:f2} leva needed.");
            }
        }
    }
}
