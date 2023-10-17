using System;

namespace Exam_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sugar = Console.ReadLine();
            int sugarCnt = int.Parse(Console.ReadLine());
            int dayOfDecember = int.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;
            double totalPrice = 0;
            if (dayOfDecember <= 15)
            {
                if (sugar == "Cake")
                {
                    price = 24;
                }
                else if (sugar == "Souffle")
                {
                    price = 6.66;
                }
                else if (sugar == "Baklava")
                {
                    price = 12.60;
                }
            }
            else if (dayOfDecember > 15)
            {
                if (sugar == "Cake")
                {
                    price = 28.70;
                }
                else if (sugar == "Souffle")
                {
                    price = 9.80;
                }
                else if (sugar == "Baklava")
                {
                    price = 16.98;
                }
            }
            totalPrice = sugarCnt * price;

            if (dayOfDecember <= 22)
            {
                if (totalPrice >= 100 && totalPrice <= 200)
                {
                    price *= 0.85;
                }
                else if (totalPrice > 200)
                {
                    price *= 0.75;
                }
            }
            if (dayOfDecember <= 15)
            {
                 price *= 0.90;
            }
            totalPrice = sugarCnt * price;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
