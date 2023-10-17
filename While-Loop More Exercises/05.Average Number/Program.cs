using System;

namespace _05.Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            int x = int.Parse(Console.ReadLine());

            for (double total = 1; total <= x; total++)
            {
                int n = int.Parse(Console.ReadLine());
                num += n;
            }
            double average = num / x;
            Console.WriteLine($"{average:f2}");
        }
    }
}
