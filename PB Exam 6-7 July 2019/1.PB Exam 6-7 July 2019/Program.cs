using System;

namespace PB_Exam_6_7_July_2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            double entranceTax = double.Parse(Console.ReadLine());
            double sunbedPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double totalEntryPrice = entranceTax * peopleCount;
            double sunbedCount = Math.Ceiling(peopleCount * 0.75);
            double umbrellaCount = Math.Ceiling(peopleCount / 2.0);

            double totalSum = totalEntryPrice + sunbedCount * sunbedPrice + umbrellaCount * umbrellaPrice;

            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}