using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int badMarksCount = 0;
            double totalMark = 0;
            int gradeNum = 1;

            while (gradeNum <= 12)
            {
                double mark = double.Parse(Console.ReadLine());
                totalMark += mark;

                if (mark < 4)
                {
                    badMarksCount++;

                    if (badMarksCount > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {gradeNum} grade");
                        return;
                    }
                }
                else
                {
                    gradeNum++;
                }
            }
            double averageMark = totalMark / (12 + badMarksCount);
            Console.WriteLine($"{name} graduated. Average grade: {averageMark:f2}");
        }
    }
}
