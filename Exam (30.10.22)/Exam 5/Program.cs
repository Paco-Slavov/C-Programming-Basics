using System;
using System.Reflection.Metadata.Ecma335;

namespace Exam_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int kids = 0;
            int adults = 0;
            int toyPrice = 5;
            int sweaterPrice = 15;
            int totalToysPrice = 0;
            int totalSweatersPrice = 0;

            while ((input = Console.ReadLine()) != "Christmas")
                {
                int age = int.Parse(input);

                if (age <= 16)
                {
                    kids++;
                }
                else if (age > 16)
                {
                    adults++;
                }
            }
            totalToysPrice = kids * toyPrice;
            totalSweatersPrice = adults * sweaterPrice;

            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {totalToysPrice}");
            Console.WriteLine($"Money for sweaters: {totalSweatersPrice}");
        }
    }
}
