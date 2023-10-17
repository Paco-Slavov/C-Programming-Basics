using System;
using System.ComponentModel.Design;
using System.Data;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int lines = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double income = 0.0;

            if (type == "Premiere")
            {
                income = lines * colums * 12.00;
            }
            else if (type == "Normal")
            {
                income = lines * colums * 7.50;
            }
            else if (type == "Discount")
            {
                income = (lines * colums * 5.00);
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
