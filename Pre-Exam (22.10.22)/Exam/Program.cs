using System;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rollsPapper = int.Parse(Console.ReadLine());
            int rollsCLoth = int.Parse(Console.ReadLine());
            double litersOfGlue = double.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double percentage = percentDiscount / 100.0;

            double papperPrice = 5.80;
            double clothPrice = 7.20;
            double glue = 1.20;

            double totalPrice = (rollsPapper * papperPrice) + (rollsCLoth * clothPrice) + (litersOfGlue * glue);
            double money = totalPrice * percentage;
            double totalPrices = totalPrice - money;
            Console.WriteLine($"{totalPrices:f3}");
        }
    }
}