using System;

namespace _01.Movie_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            double percentForCinema = double.Parse(Console.ReadLine());

            double taxForCinema = percentForCinema / 100.0;

            double profitForDay = tickets * ticketPrice;
            double totalProfit = days * profitForDay;
            double profitForCinema = totalProfit * taxForCinema;
            double studioProfit = totalProfit - profitForCinema;

            Console.WriteLine($"The profit from the movie {movieName} is {studioProfit:f2} lv.");
        }
    }
}
