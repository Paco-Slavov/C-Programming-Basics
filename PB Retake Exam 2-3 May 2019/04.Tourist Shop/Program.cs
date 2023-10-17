using System;

namespace _04.Tourist_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double discount = 0;
            double cntProducts = 0;

            while (command != "Stop" || budget < 0)
            {
                string productName = Console.ReadLine();
                double productPrice = double.Parse(Console.ReadLine());

                if (productPrice % 3 == 0)
                {
                    productPrice *= 0.5;
                }
                cntProducts = budget - productPrice;

                if (budget <= 0)
                {
                    double neededMoney = budget - productPrice;
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {neededMoney} leva!");
                    break;
                }

                if (budget > 0)
                {
                    double moneyLeft = budget - productPrice;
                    Console.WriteLine($"You bought {cntProducts} products for {productPrice} leva.");
                }
            }
        }
    }
}
