using System;
using System.Data.SqlTypes;
using System.Net;
using System.Runtime.CompilerServices;

namespace _04.PB_Exam_6_7_April_2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int tickets = 0;
            int otherStuff = 0;
            string product = Console.ReadLine();

            while (product != "End")
            {
                if (product.Length > 8)
                {
                    if (budget >= (product[0] + product[1]))
                    {
                        tickets++;
                        budget = budget - (product[0] + product[1]);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (budget >= product[0])
                    {
                        otherStuff++;
                        budget -= product[0];
                    }
                    else
                    {
                        break;
                    }
                }
                product = Console.ReadLine();
            }
            Console.WriteLine(tickets);
            Console.WriteLine(otherStuff);
        }
    }
}