using System;

namespace _02.Safari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double litresGas = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double gas = litresGas * 2.10;
            double guidePrice = 100;
            double moneyForSafari = gas + guidePrice;

            if (day == "Saturday")
            {
                moneyForSafari *= 0.9;
            }
            else if (day == "Sunday")
            {
                moneyForSafari *= 0.8;
            }
            if (budget >= moneyForSafari)
            {
                double moneyLeft = budget - moneyForSafari;
                Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv.");
            }
            else
            {
                double neededMoney = moneyForSafari - budget;
                Console.WriteLine($"Not enough money! Money needed: {neededMoney:f2} lv.");
            }
        }
    }
}
