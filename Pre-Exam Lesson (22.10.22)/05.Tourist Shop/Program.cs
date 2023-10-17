using System;

namespace _05.Tourist_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string productName;

            int counter = 0;
            double totalPrice = 0;
            while ((productName = Console.ReadLine()) != "Stop")
            {
                double productPrice = double.Parse(Console.ReadLine());
                counter++;

                if (counter % 3 == 0)
                {
                    productPrice /= 2;
                }

                totalPrice += productPrice;
                if (totalPrice > budget)
                {
                    break;
                }
            }
            if (totalPrice > budget)
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"You don't have enough money!");
                Console.WriteLine($"You need {moneyNeeded:f2} leva!");
            }
            else
            {
                Console.WriteLine($"You bought {counter} products for {totalPrice:f2} leva.");
            }
        }
    }
}
