using System;

namespace _01.Fruit_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberries = double.Parse(Console.ReadLine());
            double strawberriesKg = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberriesPrice * 0.5;
            double orangesPrice = raspberriesPrice - (0.4 * raspberriesPrice);
            double bananasPrice = raspberriesPrice - (0.8 * raspberriesPrice);

            double raspberriesTotal = raspberries * raspberriesPrice;
            double orangesTotal = oranges * orangesPrice;
            double bananasTotal = bananas * bananasPrice;
            double strawberriesTotal = strawberriesKg * strawberriesPrice;
            double totalMoney = raspberriesTotal + orangesTotal + bananasTotal + strawberriesTotal;


            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
