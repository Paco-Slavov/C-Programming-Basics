using System;

namespace _05.Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int serials = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int serial = 1; serial <= serials; serial++)
            {
                string serialName = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                if (serialName == "Thrones")
                {
                    price *= 0.5;
                }
                else if (serialName == "Lucifer")
                {
                    price *= 0.6;
                }
                else if (serialName == "Protector")
                {
                    price *= 0.7;
                }
                else if (serialName == "TotalDrama")
                {
                    price *= 0.8;
                }
                else if (serialName == "Area")
                {
                    price *= 0.9;
                }
                totalPrice += price;
            }
            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"You bought all the series and left with {moneyLeft:f2} lv.");
            }
            else
            {
                double neededMoney = totalPrice - budget;
                Console.WriteLine($"You need {neededMoney:f2} lv. more to buy the series!");
            }
        }
    }
}
