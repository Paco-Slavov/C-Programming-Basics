using System;

namespace _11.Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());

            double pricePerWorkDay = 0;
            double pricePerWeekend = 0;

            switch (fruit)
            {
                case "banana":
                    pricePerWorkDay = 2.50;
                    pricePerWeekend = 2.70;
                    break;
                case "apple":
                    pricePerWorkDay = 1.20;
                    pricePerWeekend = 1.25;
                    break;
                case "orange":
                    pricePerWorkDay = 0.85;
                    pricePerWeekend = 0.90;
                    break;
                case "grapefruit":
                    pricePerWorkDay = 1.40;
                    pricePerWeekend = 1.60;
                    break;
                case "kiwi":
                    pricePerWorkDay = 2.70;
                    pricePerWeekend = 3.00;
                    break;
                case "pineapple":
                    pricePerWorkDay = 5.50;
                    pricePerWeekend = 5.60;
                    break;
                case "grapes":
                    pricePerWorkDay = 3.85;
                    pricePerWeekend = 4.20;
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }
            switch (day)
            {
                case "Monday":
                    Console.WriteLine($"{qty * pricePerWorkDay:f2}");
                    break;
                case "Tuesday":
                    Console.WriteLine($"{qty * pricePerWorkDay:f2}");
                    break;
                case "Wednesday":
                    Console.WriteLine($"{qty * pricePerWorkDay:f2}");
                    break;
                case "Thursday":
                    Console.WriteLine($"{qty * pricePerWorkDay:f2}");
                    break;
                case "Friday":
                    Console.WriteLine($"{qty * pricePerWorkDay:f2}");
                    break;
                case "Saturday":
                    Console.WriteLine($"{qty * pricePerWeekend:f2}");
                    break;
                case "Sunday":
                    Console.WriteLine($"{qty * pricePerWeekend:f2}");
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }
        }
    }
}
