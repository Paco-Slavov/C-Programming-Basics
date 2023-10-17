using System;

namespace Exam_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed = int.Parse(Console.ReadLine());
            double fuel = int.Parse(Console.ReadLine());

            int distance = 384400;
            int time = 3;
            int totalDistance = distance * 2;

            double travelingTime = totalDistance / speed;
            double totalTime = travelingTime + time;

            double neededFuel = (fuel * totalDistance) / 100;

            Console.WriteLine($"{Math.Ceiling(totalTime)}");
            Console.WriteLine($"{neededFuel}");
        }
    }
}
