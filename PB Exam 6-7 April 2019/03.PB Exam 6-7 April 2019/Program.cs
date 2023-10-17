using System;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string typeHall = Console.ReadLine();
            int ticketCount = int.Parse(Console.ReadLine());
            double ticketPrice = 0;

            switch (movie)
            {
                case "Bohemian Rhapsody":

                    switch (typeHall)
                    {
                        case "normal":
                            ticketPrice = 7.35;
                            break;
                        case "luxury":
                            ticketPrice = 9.45;
                            break;
                        case "ultra luxury":
                            ticketPrice = 12.75;
                            break;
                    }
                    break;

                case "Green Book":
                    switch (typeHall)
                    {
                        case "normal":
                            ticketPrice = 8.15;
                            break;
                        case "luxury":
                            ticketPrice = 10.25;
                            break;
                        case "ultra luxury":
                            ticketPrice = 13.25;
                            break;
                    }
                    break;

                case "A Star Is Born":
                    switch (typeHall)
                    {
                        case "normal":
                            ticketPrice = 7.50;
                            break;
                        case "luxury":
                            ticketPrice = 10.50;
                            break;
                        case "ultra luxury":
                            ticketPrice = 13.50;
                            break;
                    }
                    break;

                case "The Favourite":
                    switch (typeHall)
                    {
                        case "normal":
                            ticketPrice = 8.75;
                            break;
                        case "luxury":
                            ticketPrice = 11.55;
                            break;
                        case "ultra luxury":
                            ticketPrice = 13.95;
                            break;
                    }
                    break;

            }

            double profit = ticketCount * ticketPrice;
            Console.WriteLine($"{movie} -> {profit:f2} lv.");
        }
    }
}