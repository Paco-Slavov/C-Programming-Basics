using System;

namespace _06.Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int free;
            int tickets;
            int kidTickets = 0;
            int studentTickets = 0;
            int standardTickets = 0;
            string type;

            while (input != "Finish")
            {
                free = int.Parse(Console.ReadLine());
                tickets = 0;

                type = Console.ReadLine();
                while (type != "End")
                {
                    if (type == "student")
                    {
                        studentTickets++;
                    }
                    else if (type == "standard")
                    {
                        standardTickets++;
                    }
                    else
                    {
                        kidTickets++;
                    }
                    tickets++;

                    if (tickets >= free)
                    {
                        break;
                    }
                    type = Console.ReadLine();
                }
                Console.WriteLine($"{input} - {tickets * 1.0 / free * 100:f2}% full.");
                input = Console.ReadLine();
            }
            int totalTickets = standardTickets + studentTickets + kidTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTickets * 1.0 / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standardTickets * 1.0 / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidTickets * 1.0 / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
