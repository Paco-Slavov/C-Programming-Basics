using System;

namespace _01.Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBottles = int.Parse(Console.ReadLine());
            int liquidForPlate = 5;
            int liquidForPot = 15;
            int totalLiquidQty = 0;
            int counter = 0;
            int totalNumberOfPlates = 0;
            int totalNumberOfPots = 0;

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "End")
                {
                    break;
                }
                int numberOfPlates = int.Parse(input);
                counter++;

                if (counter % 3 == 0)
                {
                    totalLiquidQty = numberOfPlates * liquidForPot;
                    totalNumberOfPlates += numberOfPlates;
                }
                else
                {
                    totalLiquidQty = numberOfPlates * liquidForPlate;
                    totalNumberOfPlates += numberOfPlates;
                }
                numberOfBottles -= totalLiquidQty;

                if (numberOfBottles < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(numberOfBottles)} ml. more necessary!");
                }
            }
            if (numberOfBottles >= totalLiquidQty || input == "End")
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{totalNumberOfPlates} dishes and {totalNumberOfPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {numberOfBottles} ml.");
            }
        }
    }
}
