using System;

namespace _03.Gymnastics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string tool = Console.ReadLine();

            double grade = 0;

            if (tool == "ribbon")
            {
                if (country == "Russia")
                {
                    grade = 9.1 + 9.4;
                }
                else if (country == "Bulgaria")
                {
                    grade = 9.6 + 9.4;
                }
                else if (country == "Italy")
                {
                    grade = 9.2 + 9.5;
                }
            }
            else if (tool == "hoop")
            {
                if (country == "Russia")
                {
                    grade = 9.3 + 9.8;
                }
                else if (country == "Bulgaria")
                {
                    grade = 9.55 + 9.75;
                }
                else if (country == "Italy")
                {
                    grade = 9.45 + 9.35;
                }
            }
            else if (tool == "rope")
            {
                if (country == "Russia")
                {
                    grade = 9.6 + 9.0;
                }
                else if (country == "Bulgaria")
                {
                    grade = 9.5 + 9.4;
                }
                else if (country == "Italy")
                {
                    grade = 9.7 + 9.15;
                }
            }
            double pointsToMax = 20 - grade;
            double percentsToMax = (pointsToMax / 20) * 100;

            Console.WriteLine($"The team of {country} get {grade:f3} on {tool}.");
            Console.WriteLine($"{percentsToMax:f2}%");
        }
    }
}
