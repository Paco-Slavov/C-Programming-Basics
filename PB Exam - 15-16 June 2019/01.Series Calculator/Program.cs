using System;

namespace _01.Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double timeWithoutAds = double.Parse(Console.ReadLine());

            double adsMinutes = 0.20 * timeWithoutAds; // време за реклами
            double totalMinutes = timeWithoutAds + adsMinutes; // продължителност на епизод с реклами
            double extraTime = seasons * 10; // допълнително време
            double totalTime = totalMinutes * episodes * seasons + extraTime; // Общо време за гледане

            Console.WriteLine($"Total time needed to watch the {serial} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}
