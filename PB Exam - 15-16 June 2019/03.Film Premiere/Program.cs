using System;

namespace _03.Film_Premiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string project = Console.ReadLine();
            string packet = Console.ReadLine();
            int ticketsCnt = int.Parse(Console.ReadLine());

            double price = 0;

            if (project == "John Wick")
            {
                if (packet == "Drink")
                {
                    price = 12;
                }
                else if (packet == "Popcorn")
                {
                    price = 15;
                }
                else if (packet == "Menu")
                {
                    price = 19;
                }
            }
            else if (project == "Star Wars")
            {
                if (packet == "Drink")
                {
                    price = 18;
                }
                else if (packet == "Popcorn")
                {
                    price = 25;
                }
                else if (packet == "Menu")
                {
                    price = 30;
                }
            }
            else if (project == "Jumanji")
            {
                if (packet == "Drink")
                {
                    price = 9;
                }
                else if (packet == "Popcorn")
                {
                    price = 11;
                }
                else if (packet == "Menu")
                {
                    price = 14;
                }
            }
            double totalPrice = ticketsCnt * price;

            if (project == "Star Wars" && ticketsCnt >= 4)
            {
                totalPrice *= 0.7;
            }
            else if (project == "Jumanji" && ticketsCnt == 2)
            {
                totalPrice *= 0.85;
            }
            Console.WriteLine($"Your bill is {totalPrice:f2} leva.");
        }
    }
}
