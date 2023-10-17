using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfExtras = int.Parse(Console.ReadLine());
            double clothersPrice = double.Parse(Console.ReadLine());
            double decorPrice = budget * 0.10;

            if (numberOfExtras > 150)
            {
                clothersPrice *= 0.90;
            }
            double finalPriceForClothers = clothersPrice * numberOfExtras;
            double totalSum = finalPriceForClothers + decorPrice;

            if (totalSum <= budget)
            {
                double moneyLeft = budget - totalSum;

                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }

            else
            {
                double needMoney = totalSum - budget;

                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needMoney:f2} leva more.");
            }
        }
    }
}