using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double minBudget;
            double savedMoney = 0;
            double money = 0;

            while (destination != "End")
            {
                minBudget = double.Parse(Console.ReadLine());
                savedMoney = 0;
                
                while (minBudget > savedMoney)
                {
                    money = double.Parse(Console.ReadLine());
                    savedMoney += money;
                }
                Console.WriteLine($"Going to {destination}!");
               destination = Console.ReadLine();
            }
        }
    }
}
