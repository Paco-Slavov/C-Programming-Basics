using System;

namespace _02.Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double profit = double.Parse(Console.ReadLine());
            
            double cashPayment = 0;
            double cardPayment = 0;
            double cashCounter = 0;
            double cardCounter = 0;
            int counter = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine($"Failed to collect required money for charity.");
                    return;
                }

                double cash = double.Parse(input);

                counter++;

                if (counter % 2 != 0)
                {
                    if (cash > 100)
                    {
                        Console.WriteLine($"Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine($"Product sold!");
                        cashPayment += cash;
                        cashCounter++;
                    }
                }
                else
                {
                    if (cash < 10)
                    {
                        Console.WriteLine($"Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine($"Product sold");
                        cardPayment += cash;
                        cardCounter++;
                    }
                }
                if (cashPayment + cardPayment >= profit)
                {
                    Console.WriteLine($"Average CS: {cashPayment / cashCounter:f2}");
                    Console.WriteLine($"Average CC: {cardPayment / cardCounter:f2}");
                    return;
                }
            }
        }
    }
}
