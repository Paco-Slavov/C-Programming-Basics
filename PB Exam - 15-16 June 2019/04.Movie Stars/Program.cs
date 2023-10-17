using System;

namespace _04.Movie_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            bool endBudget = false;
            string command = Console.ReadLine();

            while (command != "ACTION")
            {
                string actor = command;
                double salary = 0;

                if (actor.Length <= 15)
                {
                    salary = double.Parse(Console.ReadLine());
                }
                else
                {
                    salary = 0.20 * budget;
                }
                budget -= salary;

                if (budget <= 0)
                {
                    Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
                    endBudget = true;
                    break;
                }
                command = Console.ReadLine();
            }
            if (!endBudget)
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
        }
    }
}