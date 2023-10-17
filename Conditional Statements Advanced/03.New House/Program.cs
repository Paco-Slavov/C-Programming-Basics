using System;
using System.Buffers;
using System.Reflection;

namespace _03.New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            switch (flowersType)
            {
                case "Roses":
                    price = 5;
                    break;
                case "Dahlias":
                    price = 3.80;
                    break;
                case "Tulips":
                    price = 2.80;
                    break;
                case "Narcissus":
                    price = 3;
                    break;
                case "Gladiolus":
                    price = 2.50;
                    break;
            }
            double totalPrice = flowers * price;
            if (flowersType == "Roses" && flowers > 80)
            {
                totalPrice *= 0.9;
            }
            else if (flowersType == "Dahlias" && flowers > 90)
            {
                totalPrice *= 0.85;
            }
            else if (flowersType == "Tulips" && flowers > 80)
            {
                totalPrice *= 0.85;
            }
            else if (flowersType == "Narcissus" && flowers < 120)
            {
                totalPrice *= 1.15;
            }
            else if (flowersType == "Gladiolus" && flowers < 80)
            {
                totalPrice *= 1.2;
            }
            double difference = Math.Abs(totalPrice - budget);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowers} {flowersType} and {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
            }
        }
    }
}
