using System;

namespace _03.Mobile_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            string type = Console.ReadLine();
            string mobileInternet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            double monthlyPrice = 0;
            double internetTax = 0;

            if (time == "one")
            {
                if (type == "Small")
                {
                    monthlyPrice = 9.98;
                }
                else if (type == "Middle")
                {
                    monthlyPrice = 18.99;
                }
                else if (type == "Large")
                {
                    monthlyPrice = 25.98;
                }
                else if (type == "ExtraLarge")
                {
                    monthlyPrice = 35.99;
                }
            }
            if (time == "two")
            {
                if (type == "Small")
                {
                    monthlyPrice = 8.58;
                }
                else if (type == "Middle")
                {
                    monthlyPrice = 17.09;
                }
                else if (type == "Large")
                {
                    monthlyPrice = 23.59;
                }
                else if (type == "ExtraLarge")
                {
                    monthlyPrice = 31.79;
                }
            }
            if (mobileInternet == "yes" && monthlyPrice <= 10)
            {
                internetTax = 5.50;
                monthlyPrice += internetTax;
            }
            else if (mobileInternet == "yes" && monthlyPrice <= 30)
            {
                internetTax = 4.35;
                monthlyPrice += internetTax;
            }
            else if (mobileInternet == "yes" && monthlyPrice > 30)
            {
                internetTax = 3.85;
                monthlyPrice += internetTax;
            }

            totalPrice = monthlyPrice * months;
            if (time == "two")
            {
                totalPrice *= 0.9625;
            }

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}