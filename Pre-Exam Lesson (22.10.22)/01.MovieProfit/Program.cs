using System;

namespace _01.MovieProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int cinemaPercent = int.Parse(Console.ReadLine());

            double percentage = cinemaPercent / 100.0;

            double dayIncome = tickets * ticketPrice;
            double totalIncome = dayIncome * days;
            double cinemaTax = percentage * totalIncome;

            totalIncome -= cinemaTax;

            Console.WriteLine($"The profit from the movie {movieName} is {totalIncome:f2} lv.");
        }
    }
}
