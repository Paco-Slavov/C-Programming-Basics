using System;

namespace _05.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int juries = int.Parse(Console.ReadLine());

            for (int jury = 1; jury <= juries; jury++)
            {
                string juryName = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());

                double earnedPoints = juryName.Length * juryPoints / 2;
                points += earnedPoints;

                if (points >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
                    break;
                }
            }
                if (points < 1250.5)
            {
                double needPoints = 1250.5 - points;
                Console.WriteLine($"Sorry, {actorName} you need {needPoints:f1} more!");
            }
        }
    }
}
