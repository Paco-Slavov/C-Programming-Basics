using System;

namespace _03.Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetSum = int.Parse(Console.ReadLine());
            int sum = 0;
            while (true)
            {
                if (sum >= targetSum)
                {
                    break;
                }
                int currNum = int.Parse(Console.ReadLine());
                sum += currNum;
            }
            Console.WriteLine(sum);
        }
    }
}
