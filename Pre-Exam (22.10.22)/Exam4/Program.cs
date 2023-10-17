using System;

namespace Exam4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int input;
            double rating;
            int profit;
            double rateProfit;
            double profitSum = 0;
            double ratingSum = 0;

            for (int countComputers = 1; countComputers <= n; countComputers++)
            {
                input = int.Parse(Console.ReadLine());
                rating = input / 10; //за първите 2
                profit = input % 10; //за последната
                
                if (rating == 2)
                {
                    rateProfit = profit * 0.00;
                }
                else if (rating == 3)
                {
                    rateProfit = profit * 50 / 100.0;
                }
                else if (rating == 4)
                {
                    rateProfit = profit * 70 / 100.0;
                }
                else if (rating == 5)
                {
                    rateProfit = profit * 85 / 100.0;
                }
                else
                {
                    rateProfit = profit;
                }
                profitSum += rateProfit;
                ratingSum += rating;
            }
            double ratingAve = ratingSum / n;
            Console.WriteLine($"{profitSum:f2}");
            Console.WriteLine($"{ratingAve:f2}");
        }
    }
}
