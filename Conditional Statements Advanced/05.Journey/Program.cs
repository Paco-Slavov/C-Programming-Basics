using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double  budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double spendMoney = 0;
            string type = string.Empty;
            string destination = string.Empty;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    spendMoney = budget * 0.30;
                    type = "Camp";
                }

                else if (season == "winter")
                {
                    spendMoney = budget * 0.70;
                    type = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    spendMoney = budget * 0.40;
                    type = "Camp";
                }

                else if (season == "winter")
                {
                    spendMoney = budget * 0.80;
                    type = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                spendMoney = budget * 0.90;
                type = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {spendMoney:f2}");
        }
    }
}