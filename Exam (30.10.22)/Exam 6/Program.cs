using System;
using System.Data.Common;

namespace Exam_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double goldDug = 0;
            double averageGold = 0;
            double count = 0;
            int locationCnt = int.Parse(Console.ReadLine());

            while (locationCnt > 0)
            {
                double averageGoldPerDay = double.Parse(Console.ReadLine());
                int daysCntInLocation = int.Parse(Console.ReadLine());
                
                while (daysCntInLocation > 0)
                {
                    goldDug += averageGoldPerDay;
                    daysCntInLocation -= 1;
                    count += 1;
                }
                if (daysCntInLocation == 0)
                {
                    averageGold = goldDug / count;
                    
                    if (averageGold > averageGoldPerDay)
                    {
                        Console.WriteLine($"Good job! Average gold per day: {averageGold:f2}.");
                        goldDug -= goldDug;
                        averageGold = 0;
                        count = 0;
                        daysCntInLocation -= 1;
                    }
                    else
                    {
                        averageGold = averageGoldPerDay - averageGold;
                        Console.WriteLine($"You need {averageGold} gold.");
                        goldDug = 0;
                        averageGold = 0;
                        count = 0;
                        locationCnt -= 1;
                    }
                }
            }
        }
    }
}
